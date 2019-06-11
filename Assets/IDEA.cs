using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDEA : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    private Rigidbody2D rb2D;
    public GameControl gameControl;
    public float upForce;                   //Upward force of the "flap".
    private bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
         rb = this.GetComponent<Rigidbody2D>();
         rb.velocity = new Vector2(-speed, 0);
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,Camera.main.transform.position.z));

        // gameControl = FindObjectOfType<GameControl>();
        // rb2D = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(-4, 0);

    }


    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x < screenBounds.x)
        //{
        //   // Destroy(this.gameObject);
        //}

        if (gameControl.gameOver == true)
        {
            rb.velocity = Vector2.zero;
        }
    }
}

///////////////
///















    ///////////////////