using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class force : MonoBehaviour
{
    public float pushForce = 10.0f;
    public GameObject FireBallPrefab;

    void Start()
    {
        Vector3 fireBallStartPosition = transform.position + new Vector3(0, 0.5f, 0);
        GameObject fireBall = Instantiate(FireBallPrefab, fireBallStartPosition, Quaternion.identity);
        Rigidbody2D fireBallRb = fireBall.GetComponent<Rigidbody2D>();
        fireBallRb.AddForce(Vector2.up * pushForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FireBall"))
        {
            Rigidbody2D fireBallRb = collision.gameObject.GetComponent<Rigidbody2D>();
            fireBallRb.AddForce(Vector2.up * pushForce, ForceMode2D.Impulse);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Got Burned");
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
