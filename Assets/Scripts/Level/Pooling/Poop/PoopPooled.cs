using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PoopPooled : MonoBehaviour
{ 

    [SerializeField]
    SavingManager SavingPoop;


    [SerializeField]
    Animator PoopAnima;
    [SerializeField]
    AudioSource fartSound;

    private float rePoopRate;
    [SerializeField]
    private float rePoopRateMin;
    [SerializeField]
    private float rePoopRateMax;
    private float poopTimer = 0;

    private Vector2 poopPosition;
    public Vector2 PoopPostion { get { return poopPosition; } }


    private float poopTime;
    public float  PoopTimer { get { return poopTime; } }

    void Update()
    {
        //Treba da snimim i ove dve kordinate da bi se odmah istanciralo ako treba
        //poopTimer treba da se snimi.
        //30.8. treba da proverim kada pokrenem igricu jel se snimio poop timer
        rePoopRate = Random.Range(rePoopRateMin, rePoopRateMax);
        
        poopTimer += Time.deltaTime;

        if (poopTimer >= rePoopRate)
        {

            PoopAnima.enabled = true;
            if (File.Exists(@"C:\Users\goran\OneDrive\Desktop\Pooperrrr\PoopGame\player.pop"))
            {
                poopTime = poopTimer;
            }
            poopTimer = 0;
            Pooping();
            fartSound.Play();

        }
    }
    private void Pooping()
    {
        //Bitno uspeo sam na ovaj nacin da sacuvam poziciju prefaba ali se ne istancira odmah
        //zato moram da stavim da se pri startu odmah istancira ako postoji negde snimljen
        var poop = PoopPoolScript.Instance.Get();
        /* Application.persistentDataPath + "player.pop";*/
        if (File.Exists(@"C:\Users\goran\OneDrive\Desktop\Pooperrrr\PoopGame\player.pop"))
        {
            poop.transform.position = Testiranje();
        }
        else
        {
            poop.transform.position = transform.position;
        }
        
        poopPosition = transform.position;
        poop.gameObject.SetActive(true);
    }
    Vector2 Testiranje() 
    {
        Data novo = SavingData.LoadData();
        return new Vector2(novo.PoopPositionProperty[0], novo.PoopPositionProperty[1]);
    }
}
