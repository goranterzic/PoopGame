using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigboss : MonoBehaviour
{
    # region Fields
    bool   changeDirection = false;
    int    randomColor;
    float  randomDirection;
    float  randomSpeedDirection;

    public GameObject Poop;
    GameObject PoopInstante;
    #endregion

    #region Methods
    void Start()
    {
        InvokeRepeating("ColorSet", 0.17f, 0.37f);   
    }
    void FixedUpdate()
    {  
        ChangeDirection();   
    }
    void ColorSet()
    {
        randomColor = Random.Range(1, 5);
        PoopInstante = Instantiate(Poop, new Vector3(transform.position.x, transform.position.y - 0.3f), Quaternion.identity);
        PoopInstante.name = "PoopInstance";
        SpeedSet(PoopInstante,ChangeDirection());
        Renderer PoopRenderer = PoopInstante.GetComponent<Renderer>();
        switch (randomColor)
        {
            case 1:
                PoopRenderer.material.SetColor("_Color", Color.red);

                break;
            case 2:
                PoopRenderer.material.SetColor("_Color", Color.magenta);

                break;
            case 3:
                PoopRenderer.material.SetColor("_Color", Color.yellow);

                break;
            case 4:
                PoopRenderer.material.SetColor("_Color", Color.green);

                break;
            case 5:
                PoopRenderer.material.SetColor("_Color", Color.blue);

                break;
            default:
                Debug.Log("Greska iz nekog razloga. ");
                break;
        }
        Destroy(PoopInstante, 1f);
    }
    Vector2 SpeedSet(GameObject Poop, float randomSpeedDirection)
    {
      Vector2 PoopSpeed = Poop.GetComponent<Rigidbody>().velocity= new Vector2(0,-1  * randomSpeedDirection);
      return  PoopSpeed;
    }
    float ChangeDirection() 
    {
        randomSpeedDirection = Random.Range(4, 11);
        randomDirection = Random.Range(0.2f, 1.58f);
        if (changeDirection)
        {
            transform.Translate(Vector2.right * Time.deltaTime * randomSpeedDirection);
        }
        else
        {
            transform.Translate(Vector2.left * Time.deltaTime * randomSpeedDirection);
        }
        if (transform.position.x >= randomDirection)
        {
            changeDirection = false;
        }
        if (transform.position.x <= -randomDirection)
        {
            changeDirection = true;
        }
        return randomSpeedDirection;
    }
    #endregion
}

