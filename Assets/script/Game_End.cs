using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game_End : MonoBehaviour
{
    public GameObject uiObject;
    public Text tex1;

void Start()
    {
     //   uiObject.SetActive(false);
    }
void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            //PlayerPrefs.SetString("username", inputField.text);

           // string text = (string)PlayerPrefs("username");
            string username = PlayerPrefs.GetString("username");
            tex1.text = username + "님";
 
        }
    }
 

    // Update is called once per frame
    void Update()
    {
        
    }
}
