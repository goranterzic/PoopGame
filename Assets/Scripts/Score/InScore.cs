using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InScore : MonoBehaviour
{
    public void BackToMain()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
