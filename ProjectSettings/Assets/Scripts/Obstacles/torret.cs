using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torret : MonoBehaviour
{
    public float WaitTimeAttack = 3;
    public GameObject bullet;
    public Transform launchSpawnPoint;

    void Start()
    {
        InvokeRepeating("LaunchBullet", 3, WaitTimeAttack);
    }
    public void LaunchBullet()
    {
        GameObject newBullet = Instantiate(bullet, launchSpawnPoint.position, launchSpawnPoint.rotation);
    }

}
