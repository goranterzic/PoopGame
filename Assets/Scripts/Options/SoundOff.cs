using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOff : MonoBehaviour
{

    [SerializeField]
    GameObject On;
    [SerializeField]
    GameObject Off;
    
    bool NotActiv;
    private bool isActiv;

    void Awake()
    {
        if (PlayerPrefs.GetString("NotActiv")=="True")
        {
            
            Off.SetActive(true);
        }      
       //   PlayerPrefs.DeleteAll();
    }
    public void OffSound()
    {
        if (Off.active == true)
        {  
            Off.SetActive(false);
            On.SetActive(true);
            
            NotActiv = true;
            isActiv = true;
            Audio.Instance.PlayingSound(NotActiv);
            NotActiv = false;
            PlayerPrefs.SetString("NotActiv", NotActiv.ToString());
            PlayerPrefs.SetString("IsActiv", isActiv.ToString());
            PlayerPrefs.Save();
            
          
        }

    }
}
