using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondGame : TSceneController
{

    [SerializeField] private string toScene;
    private TSceneController sceneController1;
    public Transform player;
 

    // Start is called before the first frame update
    void Start()
    {
         sceneController1 = GameObject.FindGameObjectWithTag("GameController").GetComponent<TSceneController>();
    }
    private void OnTriggerEnter(Collider col)
    {
        //sceneController1 = GameObject.FindGameObjectWithTag("backtosecond").GetComponent<TSceneController>();

        if (col.CompareTag("Player"))
        {
             
                //   base.Start();
                //    Destroy(GameObject.FindGameObjectWithTag("Coin2"));

                //  player.position = new Vector3(51.72f, 5.11f, 27.92f); 

                // PlayerPrefs.SetFloat("x", transform.position.x);
                //  PlayerPrefs.SetFloat("y", transform.position.y);
                //  PlayerPrefs.SetFloat("z", transform.position.z);
                sceneController1.LoadScene(toScene);
             
        }
    }
}
