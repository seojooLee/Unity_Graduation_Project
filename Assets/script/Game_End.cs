using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Game_End : PlayerScript
{
        public GameObject uiObject;
        public static int  sec;
    public static int  min;
    public TextMeshPro tmpScore;
 
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

            PlayTimer.real_time = false;


            sec = PlayerPrefs.GetInt("sec");
            min = PlayerPrefs.GetInt("min");
            tmpScore.text = min + ":" + sec;


            PlayerScript.Onsubmit();

            OngetScore();
 
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
