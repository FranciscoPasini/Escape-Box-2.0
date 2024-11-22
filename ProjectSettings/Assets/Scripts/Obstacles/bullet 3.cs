using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet3 : MonoBehaviour
{
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
