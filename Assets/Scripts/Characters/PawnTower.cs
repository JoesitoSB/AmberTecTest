using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnTower : BaseTower
{
    protected override void Attack()
    {
        if (GameStateController.GetCurrentState != GameStates.Play) return;

        var bullet = Instantiate(towerInfo.BulletsPrefab,
                                    transform.position,
                                    Quaternion.Euler(0, 0, -90), transform)
                                    .GetComponent<TowerNormalBullet>();
        bullet.Init(towerInfo.BulletSpeed, towerInfo.Damage);
        Invoke(nameof(Attack), towerInfo.AttackSpeed);
    }

    protected override void Die()
    {
        //Just die and notify the necesary script that this tower die
        Destroy(gameObject);
    }
}
