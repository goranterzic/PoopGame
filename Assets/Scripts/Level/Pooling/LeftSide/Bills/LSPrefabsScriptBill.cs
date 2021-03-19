﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSPrefabsScriptBill : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed;

    private float lifeTime;
    private float maxLifetime = 2f;
    private void OnEnable()
    {
        lifeTime = 0f;
    }


    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        lifeTime += Time.deltaTime;
        if (lifeTime > maxLifetime)
        {
            LSPoolScriptBill.Instance.ReturnToPool(this);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            LSPoolScriptBill.Instance.ReturnToPool(this);
        }
        Debug.Log(collision.gameObject);
    }

}
