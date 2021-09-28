using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{
    
    private long scorePrefs;
    public long ScorePrefs { get { return scorePrefs; } }
    

    private float[] PlayerPosition = new float[2];
    public float[] PlayerPositionProperty { get { return PlayerPosition; } }
    

    private float[] BossPosition = new float[2];
    public float[] BossPositionProperty { get { return BossPosition; } }
    
    
    private float[] PoopPosition = new float[2];
    public float[] PoopPositionProperty { get { return PoopPosition; } }


    private bool PoopActiveBool;
    public bool PoopPositionActiveBool { get { return PoopActiveBool; } }


    private int life;
    public int LifeProop { get { return life; } }

    private float poopTTimer;
    public float PoopTimerProp { get { return poopTTimer; } }

    public Data(ScoreScript scoreScript, PlayerScript playerScript,
        Bigboss bigboss, PoopPoolScript poopPoolScript,Life lifee, float poopTimer) 
    {
        //Score
        scorePrefs = scoreScript.ScoreScpitProp;
        //Player
        PlayerPosition[0] = playerScript.transform.position.x;
        PlayerPosition[1] = playerScript.transform.position.y;
        //BigBoss
        BossPosition[0] = bigboss.transform.position.x;
        BossPosition[1] = bigboss.transform.position.y;
        //Poop
        PoopPosition[0] = poopPoolScript.transform.position.x;
        PoopPosition[1] = poopPoolScript.transform.position.y;
        if (poopPoolScript.gameObject.active)
        {
            PoopActiveBool = true;
        }
        else
        {
            PoopActiveBool = false;
        }
        //Nadji nacin da kazes da je true ili false iz poolja
        //PoopPositionPropertyBool = poopPoolScript.gameObject.

        //Life
        life = lifee.IndexLifeProp;
        poopTTimer = poopTimer;

    }
}
