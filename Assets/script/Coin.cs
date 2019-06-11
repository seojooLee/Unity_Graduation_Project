using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{ 
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {

        if(col.gameObject.name == "Player")
        {
            Debug.Log("오브젝트와 충돌했습니다. ");
             SceneManager.LoadScene("GameMain"); 
        }
    }

    void Start()
    { 
    }

    }
 
 
