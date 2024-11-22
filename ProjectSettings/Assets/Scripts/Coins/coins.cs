using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, 1, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Coin Collected");
            Destroy(gameObject);
            FindObjectOfType<allCoins>().allCoinsCollected();
        }

    }
}
