using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUser : MonoBehaviour
{
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("실행합니다.");
        txt.text = PlayerPrefs.GetString("Name")+"님";
     }


}
