using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesagesL2 : MonoBehaviour
{
    public SpriteRenderer great;
    public SpriteRenderer torret;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            great.enabled = false;
            torret.enabled = true;
        }
    }
}
