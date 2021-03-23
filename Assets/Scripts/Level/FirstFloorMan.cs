using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorMan : MonoBehaviour
{
    # region Fields
    [SerializeField]
    float randomDirectionRight;
    [SerializeField]
    float randomDirectionLeft;
    [SerializeField]
    float randomSpeedDirection;
    bool changeDirection = false;
  
    #endregion
    void Update()
    {
        ChangeDirection();
    }
    float ChangeDirection()
    {/*
        randomSpeedDirection = ranSpeedDir;
        randomDirectionRight = randDirRight;
        randomDirectionLeft = randDirLeft;
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
        /*
       dir = transform.position.x > randomDirection ? -1 : 1;
       transform.Translate(new Vector2(dir, 0) * Time.deltaTime * randomSpeedDirection);
       */
    }
}
