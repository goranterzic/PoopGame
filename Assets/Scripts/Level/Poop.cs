using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour
{ 
    bool  changeDirection = false;
    int   randomColor;
    float randomDirection;
    float randomSpeedDirection;
    [SerializeField] private float repeatTime;
    [SerializeField] private float repeatRate;
    [SerializeField] private float delTimePoopPrefab;
    [SerializeField] private float randDirMin;
    [SerializeField] private float randDirMax;
   

    [SerializeField] private Color[] boja;

    public GameObject PoopObject;
    GameObject PoopInstante;
    // Start is called before the first frame update
    public GameObject BoSSPrefab;

    
    void Start()
    {


        /*
        IEnumerator anim = ColorSetAnim(10f, 5);

        StartCoroutine(anim);
        StopCoroutine(anim);
        */
       // StartCoroutine(ColorSetAnim(10f,5));
       InvokeRepeating("ColorSet",0.5f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    } 


    /*
    Vector2 SpeedSet(GameObject Poop, float randomSpeedDirection)
    {
        Vector2 PoopSpeed = Poop.GetComponent<Rigidbody>().velocity = new Vector2(0, -1 * randomSpeedDirection);
        return PoopSpeed;
    }
    */




   
    /*
    float ChangeDirection()
    {
        randomSpeedDirection = Random.Range(ranSpeedDirMin, ranSpeedDirMax /*4, 11*/ /*  );

        randomDirection = Random.Range(randDirMin, randDirMax/*0.2f, 1.58f*/      /* );

        transform.Translate(new Vector2(dir, 0) * Time.deltaTime * randomSpeedDirection);

        dir = transform.position.x >= randomDirection ? -1 : 1;

        return randomSpeedDirection;
    }
    */
    
    void ColorSet()
    { 
        
        

        PoopInstante = Instantiate(PoopObject, new Vector2(BoSSPrefab.transform.position.x, BoSSPrefab.transform.position.y - 0.23f), Quaternion.identity);
        PoopInstante.name = "PoopInstance";

        Destroy(PoopInstante, delTimePoopPrefab);
    }
    /*
    private IEnumerator ColorSetAnim(float time, int repeatAmount)
    {
        float t = 0f;

        for (int i = 0; i < repeatAmount; i++)
        {
            while (t >= 1f)
            {
                t += Time.deltaTime / time;
                yield return new WaitForEndOfFrame();
            }

            ColorSet();

            t = 0;
        }
    }
    */
    
}
