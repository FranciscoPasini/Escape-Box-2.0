using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torretRaycast : MonoBehaviour
{
    bool booler;
    float timer;

    Quaternion rot;
    RaycastHit2D rhit;

    [SerializeField] float distance;
    [SerializeField] GameObject bullet;

    private void Start()
    {
        rot = new Quaternion();
    }

    private void Update()
    {
        rhit = Physics2D.Raycast(gameObject.transform.position, Vector2.down, distance);
        if (rhit.collider.CompareTag("Player"))

        {
            Debug.DrawRay(gameObject.transform.position, Vector2.down * distance, Color.green);
            timer += Time.deltaTime;
            booler = true;
        }

        if (rhit.collider == null)
        {
            Debug.DrawRay(gameObject.transform.position, Vector2.down * distance, Color.red);
            booler = false;
            timer = 0.5f;
        }

        if (booler)
        {
            if (timer >= 0.5f)
            {
                Instantiate(bullet, gameObject.transform.position, rot);
                timer = 0f;
            }
        }
    }
}
