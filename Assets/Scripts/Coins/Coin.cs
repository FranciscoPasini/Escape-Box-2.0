using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private PlayerOBS playerOBS;

    private void Start()
    {
        playerOBS = FindObjectOfType<PlayerOBS>();
    }

    private void Update()
    {
        transform.Rotate(0, 1, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerOBS.CollectCoin();
            Destroy(gameObject);
        }
    }
}
