using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower2 : BaseTower
{
    protected override void Attack()
    {
        var bullet = Instantiate(towerInfo.BulletsPrefab,
                                    transform.position,
                                    Quaternion.Euler(0, 0, -90), transform)
                                    .GetComponent<TowerNormalBullet>();
        bullet.Init(towerInfo.BulletSpeed, towerInfo.Damage);
        Invoke(nameof(Attack), towerInfo.AttackSpeed);
    }

    protected override void Die()
    {
        Destroy(gameObject);
    }
}
