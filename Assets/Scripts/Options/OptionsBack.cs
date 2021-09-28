using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsBack : MonoBehaviour
{

    public void BackToMenu()
    {

        SceneManager.LoadScene("ResumeMenu");

    }

}