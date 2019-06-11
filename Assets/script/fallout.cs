using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallout : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
             AsyncOperation async;
            async = SceneManager.LoadSceneAsync("GameMain");
            //async = SceneManager.LoadSceneAsync("GameMain");

        }
    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}
