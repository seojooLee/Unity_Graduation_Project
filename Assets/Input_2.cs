using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_2 : MonoBehaviour
{
    public InputField inputName;
    PlayTimer play = new PlayTimer();

    public void Save()
    {
        //PlayTimer.seconds = 0;
        //PlayTimer.minutes = 0;
        //PlayTimer.playtime = 0;

        //PlayTimer.real_time = true;


        PlayerPrefs.SetString("Name", inputName.text);

    }
    public void Load()
    {
        if(PlayerPrefs.HasKey("Name"))
        {
            inputName.text = PlayerPrefs.GetString("Name");
        }
    }
    
}
