using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseTower : BaseCharacter
{
    [SerializeField] protected TowerInfoScriptableObject towerInfo = null;
    protected float spawnCooldownTime = 0;
    //current board piece here

    private void Awake()
    {
        spriteRenderer.sprite = towerInfo.Sprite;
        health = towerInfo.Health;
        damage = towerInfo.Damage;
        range = towerInfo.Range;
        attackSpeed = towerInfo.AttackSpeed;
        spawnCooldownTime = towerInfo.SpawnCooldownTime;
    }

    private void Start()
    {
        Invoke(nameof(Attack), towerInfo.AttackSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered");
    }
}
