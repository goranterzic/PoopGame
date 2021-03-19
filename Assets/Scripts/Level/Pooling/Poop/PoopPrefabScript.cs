using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopPrefabScript : MonoBehaviour
{
    public float moveSpeed;
    [SerializeField]
    public float moveSpeedMin;
      [SerializeField]
    public float moveSpeedMax;

    private float lifeTime;
    private float maxLifetime = 2f;
    private void OnEnable()
    {
        lifeTime = 0f; 
    }
     

    // Update is called once per frame
    void Update()
    {
        moveSpeed = Random.Range(moveSpeedMin, moveSpeedMax);
        transform.Translate(Vector2.down*moveSpeed*Time.deltaTime);
        lifeTime += Time.deltaTime;
        if (lifeTime > maxLifetime)
        {
            PoopPoolScript.Instance.ReturnToPool(this);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            PoopPoolScript.Instance.ReturnToPool(this);
        }
    }
}
