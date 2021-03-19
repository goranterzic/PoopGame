using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InOption : MonoBehaviour
{
    public void BackToMain()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            BackToResume();
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            BackToMainMenu();
        }



    }
    public void BackToMainMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void BackToResume()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
