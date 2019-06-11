using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEOJOO : TSceneController
{
     
     private TSceneController sceneController;
    public Transform player;
    public Image imgLife1, imgLife2 ,imgLife3;     
    // Start is called before the first frame update

    void Start()
    {
        imgLife1.enabled = false;
        imgLife2.enabled = false;
        imgLife3.enabled = false;

        if (prevScene == "02.2Dfirst")
            {
                Debug.Log("02.2Dfirst 게임 실행");
                Destroy(GameObject.FindGameObjectWithTag("Coin"));

                PlayerPrefs.SetFloat("x", transform.position.x);
                PlayerPrefs.SetFloat("y", transform.position.y);
                PlayerPrefs.SetFloat("z", transform.position.z);

                player.position = new Vector3(44.8f, 5.11f, 12.36f);
                player.position = new Vector3(44.8f, 5.11f, 12.36f);
            imgLife1.enabled = true;
            imgLife2.enabled = false;
            imgLife3.enabled = false;

        }
        if (prevScene == "03.2Dsecond")
            {
                Debug.Log("03.3Dfirst 게임 실행");
            Destroy(GameObject.FindGameObjectWithTag("Coin")); 
            Destroy(GameObject.FindGameObjectWithTag("Coin2"));
                player.position = new Vector3(51.72f, 5.11f, 27.92f);
 
               PlayerPrefs.SetFloat("x", transform.position.x);
                PlayerPrefs.SetFloat("y", transform.position.y);
                PlayerPrefs.SetFloat("z", transform.position.z);
                player.position = new Vector3(51.72f, 5.11f, 27.92f);
            imgLife1.enabled = true;
            imgLife2.enabled = true;
            imgLife3.enabled = false;

        }
        if (prevScene == "04.2Dthird")
        {

            Debug.Log("04.2Dthird 게임 실행");
            Destroy(GameObject.FindGameObjectWithTag("Coin"));
            Destroy(GameObject.FindGameObjectWithTag("Coin2"));
            Destroy(GameObject.FindGameObjectWithTag("Coin3"));
            player.position = new Vector3(44.69f, 5.11f, 51.72f);

            PlayerPrefs.SetFloat("x", transform.position.x);
            PlayerPrefs.SetFloat("y", transform.position.y);
            PlayerPrefs.SetFloat("z", transform.position.z);
            player.position = new Vector3(44.69f, 5.11f, 51.72f);
            imgLife1.enabled = true;
            imgLife2.enabled = true;
            imgLife3.enabled = true;

        }
    }
}
