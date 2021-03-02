using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lawyer : MonoBehaviour
{
    #region Fields
    public GameObject LawyerObject;
    GameObject LawyerInstance;

    float RandomLawyer;
    #endregion
    #region Methods
    void Start()
    {
        InvokeRepeating("LawyerInstantiate", 1f,1f);
    }
    void Update()
    {
        RandomLawyer = Random.Range(-1f, 1f);
    }
    public void  LawyerInstantiate()
    {
        LawyerInstance = Instantiate(LawyerObject, new Vector2(RandomLawyer, 7), Quaternion.identity) as GameObject;
        LawyerInstance.name = "Lawyers";
        {
            Destroy(LawyerInstance, 1.55f);
        }  
    }
    #endregion
}
