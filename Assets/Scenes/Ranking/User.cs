using System;
using UnityEngine;


[Serializable]
public class User
{
    public string userName;
    public string userScore;

    public User()
    {
        userName = PlayerScript.playerName;
        userScore = PlayerScript.playerScore;

    }
     
    
}
