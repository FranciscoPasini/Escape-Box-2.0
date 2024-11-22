using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesageTrigger4 : MonoBehaviour
{
    public SpriteRenderer L4;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            L4.enabled = false;
        }
    }
}
