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

    private IPlayerState currentState;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        SetState(new IdleState());
        playerOBS = GetComponent<PlayerOBS>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        currentState.UpdateState(this);
    }

    public void SetState(IPlayerState newState)
    {
        currentState?.ExitState(this);

        currentState = newState;
        currentState.EnterState(this);
    }

    public void Move(float moveInput)
    {
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Plat"))
        {
            playerOBS.Die();
        }
    }
}
