using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
     void Awake()
    {
        Audio.Instance.PlayingMusic(false);

    }
    
}
