using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f;

    private int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {

            if (currentSceneIndex + 1 < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(currentSceneIndex + 1);
            }
            else
            {
                SceneManager.LoadScene("Main menu");
            }

        }
    }
}
