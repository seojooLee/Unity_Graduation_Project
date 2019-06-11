using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third_change : TSceneController
{

    [SerializeField] private string toScene;
    private TSceneController sceneController2;
    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        sceneController2 = GameObject.FindGameObjectWithTag("GameController").GetComponent<TSceneController>();
    }
    private void OnTriggerEnter(Collider col)
    {
 
        if (col.CompareTag("Player"))
        {

            sceneController2.LoadScene(toScene);

        }
    }
}
