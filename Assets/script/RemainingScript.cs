using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemainingScript : MonoBehaviour
{


            private bool thisisthecorrectone = false;
    Vector3 CharacterPosition;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void Remain()
    {

        if (GameObject.FindGameObjectsWithTag("RemainingObject").Length > 1 && thisisthecorrectone == false)
       {
        Destroy(gameObject);
      }
        else thisisthecorrectone = true;

    }

} 