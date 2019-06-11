using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 

public class Final : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        if(Panel != null)
        { 
              Panel.SetActive(true); 
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);

           
                if (Panel != null)
                {
                    Panel.SetActive(true);
 
            }

        }
    }
}
