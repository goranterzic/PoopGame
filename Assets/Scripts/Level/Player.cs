using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    # region Fields
    public GameObject Scoree;
    [SerializeField]
    public Animator PlayerAnima;
    [SerializeField]
    Sprite NewSprite;
    [SerializeField]
    SpriteRenderer SpriteComponent;
    
    Text rezultatUI;
    
    [SerializeField]
    private int scoreRed;
    private int scoreMagenta;
    private int scoreManRight;
    private int scoreManLeft;
    private int scoreLawyer;
    private int score;
    [SerializeField]
    private float playerMouvment;
    #endregion
    #region Methods
    private void Awake()
    {
       rezultatUI = Scoree.GetComponent<Text>();
    }
    void FixedUpdate()
    {
       rezultatUI.text = "Score: " + score;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {




        if (collision.gameObject.GetComponent<Renderer>().material.color.Equals(Color.white))
         {
             score -= scoreRed;
         }
         else if (collision.gameObject.GetComponent<Renderer>().material.color.Equals(Color.magenta))
         {
             score -= scoreMagenta;
         }
         else if (collision.gameObject.name == "managerLeft")
         {
             score -= scoreManLeft;
         }
         else if (collision.gameObject.name == "managerRight")
         {
             score -= scoreManRight;
         }
        Destroy(collision.gameObject);
          

    }
    private void OnMouseDown()
    {
        PlayerAnima.enabled = true;
    }
    private void OnMouseUp()
    {
        PlayerAnima.enabled = false;
        SpriteComponent.sprite = NewSprite;
    }
    private void OnMouseDrag()
    {
        PlayerAnima.SetFloat("LeftRight", transform.position.x);
        PlayerMouvment();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Lawyers")
        {
            score += scoreLawyer;
            Destroy(other.gameObject);   
        } 
    }
    void PlayerMouvment()
    {
        transform.position = new Vector2(Mathf.Clamp(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, -playerMouvment, playerMouvment), -3.3f);
    }
    #endregion
}
