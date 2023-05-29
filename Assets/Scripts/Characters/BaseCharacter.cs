using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
    [SerializeField] protected SpriteRenderer spriteRenderer = null;
    protected float damage = 0;
    protected float health = 0;
    protected float range = 0;
    protected float attackSpeed = 0;
    protected abstract void Attack();
    protected abstract void Die();

    public Vector2 GetSize()
    {
        return spriteRenderer.bounds.size;
    }

    public void Hurt(float damage)
    {
        health -= damage;
        if (health <= 0) Die();
    }
}
