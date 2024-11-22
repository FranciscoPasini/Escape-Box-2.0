using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endLevel : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0, -0.1f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Level Finished");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
