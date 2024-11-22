using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);

        }

    }
}
