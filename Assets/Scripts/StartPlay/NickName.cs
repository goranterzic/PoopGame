using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NickName : MonoBehaviour
{
    [SerializeField]
    Text NickNameText;
    [SerializeField]
    Text ApplyText;
    [SerializeField]
    Button ApplyButton;
    

    string nickName;
    public string NickNameProp { get { return nickName; } }
    public static NickName NickNameInstance {get; set;}
    private void Awake()
    {
        NickNameInstance = this;
    }
    private void Start()
    {
      
    }
    private void Update()
    {
       ColorBlock colors = ApplyButton.colors;
        if (NickNameText.text.ToString().Length > 3)
        {
            ApplyText.color = Color.white;
            colors.pressedColor = new Color32(45, 45, 45,255);

        }
        if (NickNameText.text.ToString().Length < 4)
        {
            ApplyText.color = new Color(0.6f,0.64f,0.69f,1f);
            colors.pressedColor = new Color32(255, 255, 255, 255); 
        }

        ApplyButton.colors = colors;

    }

    public void SaveNickName() 
    {
        
        if (NickNameText.text.ToString().Length > 3)
        {
            nickName = NickNameText.text.ToString();
            

        }

    }
}
