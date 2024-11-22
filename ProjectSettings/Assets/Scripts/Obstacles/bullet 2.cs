using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet2 : MonoBehaviour
{
    public float speed1 = 0.6f;

    void Start()
    {

    }
    void Update()
    {
        transform.Translate(0,speed1,0);
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
