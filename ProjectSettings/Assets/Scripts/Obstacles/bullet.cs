using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet : MonoBehaviour
{

    public float speedB = -0.6f;
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(0, speedB, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Dead");
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.transform.CompareTag("Plat"))
        {
            Destroy(gameObject);
        }
    }


}
