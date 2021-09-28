using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorMan : MonoBehaviour
{
    # region Fields
<<<<<<< Updated upstream
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
=======
    [SerializeField]float randomSpeedDirection;
    [SerializeField]float limit;
    [SerializeField] Animator ManAnima;
    bool changeDirection;
    private bool startWalk;
>>>>>>> Stashed changes
    #endregion
    private void Start()
    {
        changeDirection = false;
    }
    void Update()
    {
        if (startWalk)
        {
            ChangeDirection();
        }
    }
    void ChangeDirection()
    {
        startWalk = true;

        if (changeDirection)
        {
            transform.Translate(Vector2.right * Time.deltaTime * randomSpeedDirection);
        }
        else
        {
            transform.Translate(Vector2.left * Time.deltaTime * randomSpeedDirection);
        }
        if (transform.position.x >=limit)
        {
            startWalk = false;
            ManAnima.SetBool("side", false);
            changeDirection = false;
            
        }
        if (transform.position.x <= -limit)
        {
            startWalk = false;
            ManAnima.SetBool("side", true);
            changeDirection = true;
        }
    }
    void StopWalk() 
    {

        startWalk = false;

    }
}
