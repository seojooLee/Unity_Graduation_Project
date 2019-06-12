using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_2 : MonoBehaviour
{
    public InputField inputName;

    public void Save()
    {
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
