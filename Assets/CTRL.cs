﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTRL : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector2.left * Time.deltaTime * 7.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector2.right * Time.deltaTime * 7.0f);
        }
        
    }


}