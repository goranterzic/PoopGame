using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorMan : MonoBehaviour
{
    # region Fields
    float randomDirectionRight;
    float randomDirectionLeft;

    float randomSpeedDirection;
    bool changeDirection = false;
    [SerializeField] private float repeatTime;
    [SerializeField] private float repeatRate;
    [SerializeField] private float delTimePoopPrefab;
    [SerializeField] private float randDirRight;
    [SerializeField] private float randDirLeft;
    
   
 
   [SerializeField] private float ranSpeedDir;

    public GameObject Poop;
    GameObject PoopInstante;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeDirection();
    }
    float ChangeDirection()
    {
        randomSpeedDirection = ranSpeedDir;
        randomDirectionRight = randDirRight;
        randomDirectionLeft = randDirLeft;
        /*
        dir = transform.position.x > randomDirection ? -1 : 1;
        transform.Translate(new Vector2(dir, 0) * Time.deltaTime * randomSpeedDirection);
        */


        if (changeDirection)
        {
            transform.Translate(Vector2.right * Time.deltaTime * randomSpeedDirection);
        }
        else
        {
            transform.Translate(Vector2.left * Time.deltaTime * randomSpeedDirection);
        }
        if (transform.position.x >= randomDirectionRight)
        {
            changeDirection = false;
        }
        if (transform.position.x <= randomDirectionLeft)
        {
            changeDirection = true;
        }



        return randomSpeedDirection;
    }
}
