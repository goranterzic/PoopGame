using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOn : MonoBehaviour
{
    [SerializeField]
    GameObject On;
    [SerializeField]
    GameObject Off;
    private bool notActiv;
    bool isActiv;
    
    void Awake()
    {  
       
        if (PlayerPrefs.GetString("IsActiv") == "False")
        {
            
            On.SetActive(false);
           
        }
        if (PlayerPrefs.GetString("NotActiv") == "True")
        {
            
            Off.SetActive(true);          
        }
        if (PlayerPrefs.GetString("IsActiv") == "True")
        {
           
            On.SetActive(true);
        }
      // PlayerPrefs.DeleteAll();
    }
    public void OnSound() 
    {
        if (On.active==true)
        {
            On.SetActive(false);
            Off.SetActive(true);
            notActiv = true;
            isActiv = false;
            Audio.Instance.PlayingSound(isActiv);
            PlayerPrefs.SetString("IsActiv", isActiv.ToString());
            PlayerPrefs.SetString("NotActiv", notActiv.ToString());
            PlayerPrefs.Save();
        }
    }
}
