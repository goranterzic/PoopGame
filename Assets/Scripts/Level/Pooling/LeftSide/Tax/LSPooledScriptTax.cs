﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSPooledScriptTax : MonoBehaviour
{
    [SerializeField]
    private float reLSRate;


    private float poopTimer = 0;


    // Update is called once per frame
    void Update()
    {
       
        poopTimer += Time.deltaTime;
        if (poopTimer >= reLSRate)
        {
            poopTimer = 0;
            Pooping();
        }
    }
    private void Pooping()
    {
        var poop = LSPoolScriptTax.Instance.Get();
        poop.transform.position = transform.position;
        poop.gameObject.SetActive(true);
    }
}