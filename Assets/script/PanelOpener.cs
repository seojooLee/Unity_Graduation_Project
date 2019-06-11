using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{

    public  GameObject Panel;
     
    public void OpenPanel()
    {
        if(Panel != null)
        { 
              Panel.SetActive(true);
             
        }
    }
    public void Start()
    {
        Time.timeScale = 0;
    }

    public void ClosePanel()
    {
        if(Panel != null)
        {
            Time.timeScale = 1;
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);

         }
    }
}
