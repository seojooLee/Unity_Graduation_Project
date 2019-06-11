using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_End : MonoBehaviour
{
    public GameObject Panel;
 
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "Player")
        {
            Debug.Log("오브젝트와 충돌했습니다. ");
             
            if (Panel != null)
            {
                Panel.SetActive(true); 
            }
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
