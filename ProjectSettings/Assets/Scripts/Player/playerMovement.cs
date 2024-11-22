using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 15;
    public float jumpForce = 20;

    Rigidbody2D rb2D;

    bool isJump;

  
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(Input.GetKey("d"))
        {
            rb2D.velocity = new Vector2(speed,rb2D.velocity.y);
        }

        else if (Input.GetKey("a"))
        {
            rb2D.velocity = new Vector2(-speed,rb2D.velocity.y);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }
        if(Input.GetKey("w") && checkGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
        }

    }
}

