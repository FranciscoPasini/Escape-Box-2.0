using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour, IObstacles
{
    public GameObject bulletPrefab;

    [SerializeField] private Transform firePoint;
    [SerializeField] private Vector2 direction;
    [SerializeField] private EnemyScripteable enemyData;

    private SpriteRenderer _sprite;
    private float fireRate;
    private float timer;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        Initialize();
    }

    public void Initialize()
    {
        _sprite.sprite = enemyData.sprite;
        fireRate = enemyData.attackTime;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireRate)
        {
            FireBullet();
            timer = 0;
        }
    }

    private void FireBullet()
    {
        GameObject bullet = BulletPool.Instance.GetBullet();
        bullet.transform.position = firePoint.position;
        bullet.transform.rotation = firePoint.rotation;

        Bullet bulletScript = bullet.GetComponent<Bullet>();
        bulletScript.Launch(direction);
    }
}
