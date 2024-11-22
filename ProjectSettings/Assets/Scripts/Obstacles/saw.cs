using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saw : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0, -2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Dead");
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
