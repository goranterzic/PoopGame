using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    # region Fields
    public GameObject scoree;
    public GameObject LawyerInstance;
   
    Text rezultatUI;
   
    [SerializeField]
    private int scoreRed, scoreMagenta, scoreManRight, scoreManLeft,scoreLawyer;
    [SerializeField]
    private float playerMouvment;
    int score;
    #endregion
    #region Methods
    private void Awake()
    {
        rezultatUI = scoree.GetComponent<Text>();
    }
    void FixedUpdate()
    {
        rezultatUI.text = "Score: " + score;
        PlayerMouvment();
    }
    private void OnCollisionEnter(Collision collision)
    {    
        if (collision.gameObject.GetComponent<Renderer>().material.color.Equals(Color.red))
        {
            score += scoreRed;
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
    void PlayerMouvment() 
    { 
        transform.position = new Vector2(Mathf.Clamp(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, -playerMouvment, playerMouvment),
        Mathf.Clamp(Camera.main.ScreenToWorldPoint(Input.mousePosition).y,-4.3f,0.5f));   
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Lawyers")
        {
            score += scoreLawyer;
            Destroy(other.gameObject);
        
        } 
    }
    #endregion
}
