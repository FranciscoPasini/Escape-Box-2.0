using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saw : MonoBehaviour, IObstacles
{
    private float rotationSpeed;
    [SerializeField] private EnemyScripteable enemyData;

    private SpriteRenderer _sprite;
    private PlayerOBS playerOBS;

    private void Start()
    {
        playerOBS = FindObjectOfType<PlayerOBS>();
        _sprite = GetComponent<SpriteRenderer>();
        Initialize();
    }

    public void Initialize()
    {
        _sprite.sprite = enemyData.sprite;
        rotationSpeed = enemyData.attackTime;
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            playerOBS.Die();
        }
    }
}
