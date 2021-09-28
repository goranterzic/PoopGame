using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOff : MonoBehaviour
{
    [SerializeField]
    GameObject On;
    [SerializeField]
    GameObject Off;

    /*
    public void OffMusic()
    {
        if (Off.active == true)
        {
            Off.SetActive(false);
            On.SetActive(true);
            Audio.Instance.PlayingMusic();
        }
    }




    [SerializeField]
    GameObject On;
    [SerializeField]
    GameObject Off;
    */
    bool NotActivMusic;
    private bool isActivMusic;

    void Awake()
    {
        if (PlayerPrefs.GetString("NotActivMusic") == "True")
        {
            Debug.Log(5);

            Off.SetActive(true);
        }
       //  PlayerPrefs.DeleteAll();
    }
    public void OffMusic()
    {
        if (Off.active == true)
        {
            Off.SetActive(false);
            On.SetActive(true);

            NotActivMusic = true;
            isActivMusic = true;
            Audio.Instance.PlayingMusic(NotActivMusic);
            NotActivMusic = false;
            PlayerPrefs.SetString("NotActivMusic", NotActivMusic.ToString());
            PlayerPrefs.SetString("IsActivMusic", isActivMusic.ToString());
            PlayerPrefs.Save();


        }

    }
}
