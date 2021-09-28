using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOn : MonoBehaviour
{
    
    [SerializeField] GameObject On;
    [SerializeField] GameObject Off;
  
    private bool notActivMusic;
    bool isActivMusic;

    void Awake()
    {

        if (PlayerPrefs.GetString("IsActivMusic") == "False")
        {
            Debug.Log(1);
            On.SetActive(false);

        }
        if (PlayerPrefs.GetString("NotActivMusic") == "True")
        {
            Debug.Log(2);
            Off.SetActive(true);
        }
        if (PlayerPrefs.GetString("IsActivMusic") == "True")
        {
            Debug.Log(3);
            On.SetActive(true);
        }
      //  PlayerPrefs.DeleteAll();
    }
    public void OnMusic()
    {
        if (On.active == true)
        {
            On.SetActive(false);
            Off.SetActive(true);
            notActivMusic = true;
            isActivMusic = false;
            Audio.Instance.PlayingMusic(isActivMusic);
            PlayerPrefs.SetString("IsActivMusic", isActivMusic.ToString());
            PlayerPrefs.SetString("NotActivMusic", notActivMusic.ToString());
            PlayerPrefs.Save();
        }
    }
}
