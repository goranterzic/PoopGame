using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButton : MonoBehaviour
{
    private void Awake()
    {
        Audio.Instance.PlayingMusic(false);

    }
    public void BackToMain()
    {
         Audio.Instance.PlayingMusic(true);
         SceneManager.LoadScene("Start");
    }

}
