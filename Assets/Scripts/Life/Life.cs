using Firebase.Auth;
using Firebase.Database;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    //FireBase
    DatabaseReference reference;
    FirebaseAuth auth;
    FirebaseUser user;
    [SerializeField]
    SavingManager savingManager;
    [SerializeField]
    GameObject[] LifeArray = new GameObject[6];
    [SerializeField]
    GameObject Boom;
    [SerializeField]
    PlayerScript playerScript;
    [SerializeField]
    TrigerScript trigerScript;
    [SerializeField]
    ScoreScript scoreScript;
    [SerializeField]
    private long increaseLife;
    private bool trigScore;
    [SerializeField]
    private long addLife;
    private int loseLife = 0;
    private int getLife = 0;
    private int indexLife;

    private int indexLife1;
    public int IndexLifeProp { get { return indexLife1; } }

    private void Awake() 
    {
       
        for (int i = 0; i < 6; i++)
        {
            LifeArray[i].SetActive(false);
        }
    }
    private void Start()
    {
        //FireBase
         reference = FirebaseDatabase.DefaultInstance.RootReference;
         auth = FirebaseAuth.DefaultInstance;
        
        if (!File.Exists(@"C:\Users\goran\OneDrive\Desktop\Pooperrrr\PoopGame\player.pop"))
        {
         
            for (int i = 0; i < LifeArray.Length / 2; i++)
            {
                LifeArray[i].SetActive(true);
            }
            
        }
        
        if (File.Exists(@"C:\Users\goran\OneDrive\Desktop\Pooperrrr\PoopGame\player.pop"))
        {
           
            for (int i = 0; i < SavingData.LoadData().LifeProop ; i++)
            {
                LifeArray[i].SetActive(true);
            }
            trigScore = true;
            

        }

    }   
    void Update()
    {
        PlayerLife();
    }

    private void PlayerLife()
    {
      
        if (trigScore ==  true)
        {
            addLife = (scoreScript.ScoreScpitProp + 1);
            trigScore = false;
        }

        for (int i = 0; i < LifeArray.Length; i++)
        {
            if (LifeArray[i].active && indexLife < 6)
            {
                indexLife++;
            }

        }
        
        indexLife1 = indexLife;
        if (playerScript.Triger && indexLife > 0 )
        {
            LifeArray[indexLife - 1].SetActive(false);
            playerScript.Triger = false;
            if (scoreScript.ScoreScpitProp > addLife && indexLife == 6)
            {
               addLife = scoreScript.ScoreScpitProp + increaseLife;
            }
        }
        if (scoreScript.ScoreScpitProp >= addLife && indexLife < 6 )
        {
            addLife += increaseLife;
            LifeArray[indexLife].SetActive(true);  
        }
      
        //GAME OVER       
        if (indexLife < 1 || scoreScript.ScoreScpitProp < 0)
        {
            SceneManager.LoadScene("GameOver");
            File.Delete(@"C:\Users\goran\OneDrive\Desktop\Pooperrrr\PoopGame\player.pop");
            
            //FireBase
            UserDataBase user = new UserDataBase(NickName.NickNameInstance.NickNameProp,scoreScript.ScoreScpitProp);
            
            string json = JsonUtility.ToJson(user);
            reference.Child("Users").Child( "Zamena"/*auth.CurrentUser.UserId */).SetRawJsonValueAsync(json);
        }        
        indexLife = 0;
    }





   
   
    
   
}
