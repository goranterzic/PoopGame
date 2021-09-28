using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigboss : MonoBehaviour
{
    # region Fields
    int    dir;
    bool changeDirection = false;
    int    randomColor;
    float  randomDirection;
    float  randomSpeedDirection;
    [SerializeField] private float repeatTime;
    [SerializeField] private float repeatRate;
    [SerializeField] private float delTimePoopPrefab;
    [SerializeField] private float randDirMin;
    [SerializeField] private float randDirMax;
    [SerializeField] private int randomColorMin;
    [SerializeField] private int randomColorMax;
    [SerializeField] private int ranSpeedDirMin;
    [SerializeField] private int ranSpeedDirMax;
<<<<<<< Updated upstream
    
    public GameObject Poop;
    GameObject PoopInstante;
=======


    [SerializeField]
    Animator PoopAnima;


    [SerializeField]
    SpriteRenderer sprite;


>>>>>>> Stashed changes
    #endregion

    #region Methods
    void Start()
    {
<<<<<<< Updated upstream
        InvokeRepeating("ColorSet",repeatTime,repeatRate /*0.17f, 0.37f*/);   
=======
     
>>>>>>> Stashed changes
    }

    void FixedUpdate()
    {  
        ChangeDirection();   
    }

    float ChangeDirection()
    {
        randomSpeedDirection = Random.Range(ranSpeedDirMin, ranSpeedDirMax /*4, 11*/);
        randomDirection = Random.Range(randDirMin, randDirMax/*0.2f, 1.58f*/);
       
        
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

    public void BackAnimaion() 
    {

        PoopAnima.enabled = false;
        
    }


    #endregion
}

