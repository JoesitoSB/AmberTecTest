using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNormalBullet : BaseBullet
{
    private void Awake()
    {
        direction = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var tower = collision.GetComponent<BaseTower>();
        if (tower)
        {
            tower.Hurt(damage);
            Destroy(gameObject);
        }
    }
}
