using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagersAttackers : MonoBehaviour
{
    #region Fields
    public GameObject managerEnemyLeft;
    public GameObject managerEnemyRight;
    float DestroydCoordinate = 1.6f;
    #endregion
    #region Methods
    void Start()
    {
        InvokeRepeating("IstanceOfManagers", 0.65f,0.65f);
    }
    void IstanceOfManagers() 
    {
        GameObject managerLeft =  (GameObject)Instantiate(managerEnemyLeft, transform.position, Quaternion.identity);
        managerLeft.name = "managerLeft";
        GameObject managerRight =  Instantiate(managerEnemyRight,new Vector2(2,7),Quaternion.identity) as GameObject;
        managerRight.name = "managerRight";
        Destroy(managerLeft,  DestroydCoordinate);
        Destroy(managerRight, DestroydCoordinate);
    }
    #endregion
}
