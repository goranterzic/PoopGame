using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SavingManager : MonoBehaviour
{

    [SerializeField]
    PlayerScript PlayerScript;

    [SerializeField]
    Bigboss BossScript;
    [SerializeField]
    PoopPrefabScript PoopPrefabScriptt;
    [SerializeField]
    PoopPoolScript poopPool;

    [SerializeField]
    GameObject PLayer;
    [SerializeField]
    GameObject Boos;
    [SerializeField]
    GameObject Poop;
   
    Vector2 PlayerPosition;
    Vector2 BossPosition;
    public Vector2 PoopPosition;
    bool poopActive;
    public bool PoopActive { get{ return poopActive; } set { } }

    [SerializeField]
    ScoreScript Score;
    private long scoreResume;
    public long ScoreResumeManager { get { return scoreResume; } }
    public Vector2 LoadPlayerPostion { get { return PlayerPosition; } }

    bool loadTrigger = false;

    [SerializeField]
    Life Lifee;
    private int life;
    public int LifeProop { get { return life; } }
    [SerializeField]
    PoopPooled poopPooled;

    #region SaveSystem
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SaveData();
            SceneManager.LoadScene("ResumeMenu");
        }
    }
    public void SaveData()
    {
        SavingData.SaveScore(Score, PlayerScript, BossScript, poopPool, Lifee, poopPooled.PoopTimer);
    }
    public void Load()
    {
       
        Data data = SavingData.LoadData();
        
        //Score
        scoreResume = data.ScorePrefs;  
        //Player
        PlayerPosition.x = data.PlayerPositionProperty[0];
        PlayerPosition.y = data.PlayerPositionProperty[1];
        PLayer.transform.position = PlayerPosition;
        //Boss
        BossPosition.x = data.BossPositionProperty[0];
        BossPosition.y = data.BossPositionProperty[1];
        Boos.transform.position = BossPosition;
        //Poop 
        //Odavde treba da loadujem sta ce se dalje desavati, to jeste da nekako u 
        //PoopClone ubacim position
        //to jeste loadujem poziciju. I da ubacim jel clone aktivan ili ne. 
        PoopPosition.x = data.PoopPositionProperty[0];
        PoopPosition.y = data.PoopPositionProperty[1];
        Poop.transform.position = PoopPosition;
        Poop.SetActive(data.PoopPositionActiveBool);
        //Treba nekako da u return to poop stavimo ovaj objekat ovde, to jeste 
        //da vidimo u kom statusu se nalazi 
       

        //Life
        life = data.LifeProop;
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Level")
        {
            loadTrigger = true;
        }
    }
    #endregion

}
