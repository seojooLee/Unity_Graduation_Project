using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Game_End : PlayerScript
{
        public GameObject uiObject;
    //    public Text tex1;

    PlayTimer play = new PlayTimer();
    void Start()
    {
        //   uiObject.SetActive(false);
    }
    public void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
             uiObject.SetActive(true);
            ////PlayerPrefs.SetString("username", inputField.text); 
 
            //// string text = (string)PlayerPrefs("username");
            //Debug.Log(PlayerPrefs.GetString("username"));
            // PlayTimer.stopTimer();
            // PlayerPrefs.SetInt("time", play.seconds); 

        }
    }
    public void push()
    {
        SceneManager.LoadScene(5);

    }
    internal bool OnTriggerEnter()
    {
        throw new NotImplementedException();
    }


    //    // Update is called once per frame
    //    void Update()
    //    {

    //    }


}
