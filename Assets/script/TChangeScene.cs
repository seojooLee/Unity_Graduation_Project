using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TChangeScene : TSceneController
{

    [SerializeField] private string toScene;
    private TSceneController sceneController;
    public Transform player;

    // Start is called before the first frame update
    public override void Start()
    {
        //sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<TSceneController>(); 
    }     
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
             
                Debug.Log("02.2Dfirst 게임 실행");
            //Destroy(GameObject.FindGameObjectWithTag("Coin"));

            //PlayerPrefs.SetFloat("x", transform.position.x);
            //PlayerPrefs.SetFloat("y", transform.position.y);
            //PlayerPrefs.SetFloat("z", transform.position.z);

            //player.position = new Vector3(44.8f, 5.11f, 12.36f);
            SceneManager.LoadScene(2);


        }
    } 
        } 
