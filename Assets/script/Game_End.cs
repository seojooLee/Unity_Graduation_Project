using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game_End : MonoBehaviour
{
    public GameObject Panel;
    public Text txt;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {  
            if (Panel != null)
            {
                Panel.SetActive(true);

            }
     

        string name = PlayerPrefs.GetString("username");
        txt.text = name + "님";

         
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
