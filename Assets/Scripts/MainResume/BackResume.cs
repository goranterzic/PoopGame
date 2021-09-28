using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackResume : MonoBehaviour
{
    public void BackToPlay() 
    {
        SceneManager.LoadScene("Start");
    }
}
