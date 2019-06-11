using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Realize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.transform.gameObject);
    } 
}
