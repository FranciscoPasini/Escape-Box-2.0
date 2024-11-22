using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Flamethrower : MonoBehaviour, IObstacles
{
    [SerializeField] private Animator fireAnimator;
    [SerializeField] private EnemyScripteable enemyData;

    private float timer;
    private float cooldownTime;
    private SpriteRenderer _sprite;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        Initialize();
    }

    public void Initialize()
    {
        _sprite.sprite = enemyData.sprite;
        cooldownTime = enemyData.attackTime;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= cooldownTime)
        {
            ActivateFire();
            timer = 0;
        }
    }

    private void ActivateFire()
    {
        fireAnimator.Play("FireActivated");
    }
}
