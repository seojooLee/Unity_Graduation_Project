using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_2 : MonoBehaviour
{
    public InputField inputField;
    //public Text text;


    // Start is called before the first frame update
    void Start()
    {

    }


    public void SaveUserName(string username)
    {
      //  text.text = inputField.text + "님";
        PlayerPrefs.SetString("username", inputField.text);

        Debug.Log("버튼 실행");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
