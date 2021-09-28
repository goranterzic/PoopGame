using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSingleton : MonoBehaviour
{

    private void Awake()
    {

        gameObject.SetActive(Audio.Instance.PlayStopSound);
    }
}


