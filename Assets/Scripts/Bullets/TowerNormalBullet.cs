using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerNormalBullet : BaseBullet
{
    private void Awake()
    {
        direction = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<BaseEnemy>();
        if (enemy)
        {
            enemy.Hurt(damage);
            Destroy(gameObject);
        }
    }
}
