using System.Collections;
using System.Collections.Generic;
using System.IO;
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

    private Vector2 poopPosition;
    public  Vector2 PoopPostion { get { return poopPosition; } }

    private void OnEnable()
    {
        lifeTime = 0f;
    }
    void Update()
    {
        //ForPoopPositionSendOnPoopPool
        PoopPoolScript.Instance.Position(this);
        moveSpeed = Random.Range(moveSpeedMin, moveSpeedMax);
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        lifeTime += Time.deltaTime;
        if (lifeTime > maxLifetime)
        {
            PoopPoolScript.Instance.ReturnToPool(this);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            PoopPoolScript.Instance.ReturnToPool(this);
        }
    }
}