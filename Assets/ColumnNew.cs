using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnNew : MonoBehaviour
{
    Rigidbody2D rb2D;
    public GameControl gameControl;
    public float upForce;                   //Upward force of the "flap".
    private bool isDead = false;            //Has the player collided with a wall?

    private Animator anim;                  //Reference to the Animator component.
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        gameControl = FindObjectOfType<GameControl>();
        rb2D = GetComponent<Rigidbody2D>();

        rb2D.velocity = new Vector2(-4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameControl.gameOver == true)
        {
            rb2D.velocity = Vector2.zero;
        }
    }

  

}
