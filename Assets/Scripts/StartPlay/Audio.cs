using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{

  
    private bool startStop=true;
    [SerializeField]
    GameObject BackgroundAudio;
    public static Audio Instance;
    public bool PlayStopSound { get { return startStop;  } }
    private void Awake()
    {

        if (Instance != null)
        {

            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }   
    }

    void Update() 
    {
       
        if (PlayerPrefs.GetString("NotActivMusic") == "True")
        {
            BackgroundAudio.SetActive(false);

        }      
        if (PlayerPrefs.GetString("NotActiv") == "True")
        {
            startStop = false;
        }

    }
    public void PlayingMusic(bool start)
    {
          BackgroundAudio.SetActive(start);   
    }
    public void PlayingSound(bool start)
    {
        startStop=start;
        

    }
    



}
