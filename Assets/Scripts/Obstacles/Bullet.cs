using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    [SerializeField] private PlayerOBS playerOBS;

    private void Start()
    {
        playerOBS = FindObjectOfType<PlayerOBS>();
    }
    public void Launch(Vector2 direction)
    {
        Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerOBS.Die();
        }
        else if (collision.CompareTag("Platform"))
        {
            gameObject.SetActive(false);
        }
    }
}
