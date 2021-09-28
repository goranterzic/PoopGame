using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    # region Fields
    [SerializeField]
    GameObject BoomSound;
    
    bool okidac = false;

    long score;
    bool triger = false;
    public bool Triger { get { return triger; } set { triger = value; } }
    public long ScorePlayerScript { get { return score; }}

    [SerializeField]
    SavingManager savingManager;
    [SerializeField]
    private long poopPrefab;
    [SerializeField]
    private long lTaxPrefab;
    [SerializeField]
    private long debtPrefab;
    [SerializeField]
    private long taxAnimaPrefab;
    [SerializeField]
    private float playerMouvment;
    [SerializeField]
    Text ScoreUI;
    [SerializeField]
    SpriteRenderer PlayerSprite;
    [SerializeField]
    Sprite DefaultSprite;
    [SerializeField]
    TrigerScript trigerScript;
    [SerializeField]
    Animator PlayerAnima;
    [SerializeField]
    GameObject DebtPrefab;
    [SerializeField]
    GameObject LTaxPrefab;
    [SerializeField]
    GameObject PoopPrefab;
    [SerializeField]
    GameObject TaxAnimaPrefab;
    [SerializeField]
    GameObject Boom;
    #endregion
    #region Methods

    private void Awake()
    {
        PlayerAnima.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        //Resi kako da ne bude ovde tag, zasto nece da radi hard reference (collision.gameObject==DebtPrefab) 
        if (collision.gameObject.tag == "DebtClone")
        {
           score += debtPrefab;
        }
        else if (collision.gameObject.tag == "LTaxClone")
        {
            score += lTaxPrefab;
        }
        else if (collision.gameObject.tag == "PoopClone")
        {
            score += poopPrefab;
         
        }
        else if (collision.gameObject.tag == "TaxAnimaClone")
        {
            score += taxAnimaPrefab;
        }


        BoomSound.SetActive(true);
        BoomSound.GetComponent<AudioSource>().Play();
        Boom.SetActive(true);
        triger = true;
       
    }

 
    

    private IEnumerator OnTriggerExit2D(Collider2D collision)
    {
        
        yield return new WaitForSeconds(0.8f);
        Boom.SetActive(false);
        BoomSound.SetActive(false);
    }
    private void OnMouseDown()
    {
        PlayerAnima.enabled = true;
    }
    private void OnMouseDrag()
    {
       
        float temporaryPosition = transform.position.x;
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x > temporaryPosition )
        {
            PlayerAnima.SetBool("Walk",false);
        }
        if(Camera.main.ScreenToWorldPoint(Input.mousePosition).x < temporaryPosition)
        {
            PlayerAnima.SetBool("Walk", true);
        }       
        PlayerMouvment();
    }
    private void OnMouseUp()
    { 
        PlayerAnima.enabled = false;
        PlayerSprite.sprite = DefaultSprite;
    }
    void PlayerMouvment() 
    {    
        transform.position = new Vector2(Mathf.Clamp(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, -playerMouvment, playerMouvment),-3.3f);  
    }

    #endregion

}
