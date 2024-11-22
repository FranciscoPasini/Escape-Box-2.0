using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private PlayerOBS playerOBS;

    private void Start()
    {
        playerOBS = FindObjectOfType<PlayerOBS>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            playerOBS.Die();
        }
    }
}
