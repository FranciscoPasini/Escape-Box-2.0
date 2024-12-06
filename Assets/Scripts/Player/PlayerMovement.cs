using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 15f;
    public float jumpForce = 25f;
    public LayerMask groundLayer;
    public Transform groundCheck;

    private Rigidbody2D rb;
    public bool isGrounded;
    private float groundCheckRadius = 0.2f;

    private PlayerOBS playerOBS;

    private SpriteRenderer sprite;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        playerOBS = GetComponent<PlayerOBS>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        SpriteUpdate();

        float moveInput = Input.GetAxisRaw("Horizontal");
        Vector2 move = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        rb.velocity = move;

        if (Input.GetKeyDown(KeyCode.W) && (isGrounded))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private void SpriteUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            sprite.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            sprite.flipX = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Plat"))
        {
            playerOBS.Die();
        }
    }
}
