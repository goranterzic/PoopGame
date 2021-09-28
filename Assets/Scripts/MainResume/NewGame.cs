using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
   public void StartNewGame() 
    {

        if (File.Exists(@"C:\Users\goran\OneDrive\Desktop\Pooperrrr\PoopGame\player.pop"))
        {
            File.Delete(@"C:\Users\goran\OneDrive\Desktop\Pooperrrr\PoopGame\player.pop");
        }
        SceneManager.LoadScene("Level");

    }
}
