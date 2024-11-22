using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flame : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Got Burned");
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.transform.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
        }
    }
}
