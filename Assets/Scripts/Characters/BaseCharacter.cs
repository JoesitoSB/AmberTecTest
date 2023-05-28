using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
    protected float damage = 0;
    protected float health = 0;
    protected abstract void Attack();
    protected abstract void Die();
}
