using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesageTrigger : MonoBehaviour
{
    public SpriteRenderer coins;
    public SpriteRenderer flamethrow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            coins.enabled = false;
            flamethrow.enabled = true;
        }
    }
}
