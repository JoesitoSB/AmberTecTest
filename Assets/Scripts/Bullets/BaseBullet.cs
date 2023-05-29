using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBullet : MonoBehaviour
{
    private float speed = 0;
    protected float damage = 0;
    protected int direction = 1;

    public void Init(float speed, float damage)
    {
        this.speed = speed;
        this.damage = damage;
    }

    private void Update()
    {
        transform.Translate(new Vector3(0, speed * Time.deltaTime * direction, 0));
    }
}
