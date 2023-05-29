using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : BaseEnemy
{
    protected override void Attack()
    {
        var bullet = Instantiate(enemyInfo.BulletsPrefab,
                                    transform.position,
                                    Quaternion.Euler(0, 0, 90), transform)
                                    .GetComponent<EnemyNormalBullet>();
        bullet.Init(enemyInfo.BulletSpeed, enemyInfo.Damage);
        Invoke(nameof(Attack), enemyInfo.AttackSpeed);
    }

    protected override void Die()
    {
        Destroy(gameObject);
    }
}
