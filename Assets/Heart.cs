using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            GameManager.instance.Score();

        }
    }
}
