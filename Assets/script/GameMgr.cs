using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    public InputField inputName;
    // Start is called before the first frame update
     
        public void Save()
    {
        PlayerPrefs.SetString("Name", inputName.text);
    }

    // Update is called once per frame
     public void Load()
    {
        if (PlayerPrefs.HasKey("Name"))
        {
            inputName.text = PlayerPrefs.GetString("Name");
        }
    }
}
