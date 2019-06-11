using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoad : MonoBehaviour
{ 
 
    void Start()
    {
        Debug.Log("the Player strated to move.");

    }
    public static GameObject objVillageCamera;
    public void load()
    { 
        Vector3 pos = transform.position; 
        Debug.Log("위치를 불러옵니다. ");
        if (PlayerPrefs.GetFloat("x") != null)
        {
            Debug.Log("Load입니다.");
            // transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
            transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
          save();
        }
    }

    public void movefirstpos()
    {

        transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));


    }


    public void save()  {

        Debug.Log("코인의 위치 has saved");
        try
        { 
            PlayerPrefs.SetFloat("x", transform.position.x);
            PlayerPrefs.SetFloat("y", transform.position.y);
            PlayerPrefs.SetFloat("z", transform.position.z);
            Debug.Log(transform.position.x);

        }
        catch (System.NullReferenceException)
        {
            Debug.Log("this is null Exception");
        } 
    }

    // Update is called once per frame
    void Update()
    { 

    }
}
