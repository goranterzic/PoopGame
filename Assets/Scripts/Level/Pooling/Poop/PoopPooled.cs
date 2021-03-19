using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopPooled : MonoBehaviour
{
    private float rePoopRate;
    [SerializeField]
    private float rePoopRateMin;
    [SerializeField]
    private float rePoopRateMax;


    private float poopTimer = 0;

    
    // Update is called once per frame
    void Update()
    {
        rePoopRate = Random.Range(rePoopRateMin,rePoopRateMax);
        poopTimer += Time.deltaTime;
        if (poopTimer >= rePoopRate)
        {
            poopTimer = 0;
            Pooping();
        } 
    }
    private void Pooping() 
    {
        var poop = PoopPoolScript.Instance.Get();
        poop.transform.position = transform.position;
        poop.gameObject.SetActive(true);
    }
}
