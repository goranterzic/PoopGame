using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resume : MonoBehaviour
{
    private void Awake()
    {
        if (!File.Exists(@"C:\Users\goran\OneDrive\Desktop\Pooperrrr\PoopGame\player.pop"))
        {
            gameObject.SetActive(false);    
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
    public void LoadLevel() 
    {

        if (File.Exists(@"C:\Users\goran\OneDrive\Desktop\Pooperrrr\PoopGame\player.pop"))
        {
            SceneManager.LoadScene("Level");
        }        
                
       
    }
   
}