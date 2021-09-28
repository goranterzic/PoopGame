using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataBase
{ 
  
    public  string nickName;
    public  long score;
    public UserDataBase(string nickName, long score) 
    {
        this.nickName = nickName;
        this.score = score;
    }
    
}
