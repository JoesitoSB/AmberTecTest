using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : BaseCharacter
{
    [SerializeField] protected EnemyInfoScriptableObject enemyInfo = null;
    protected float movementSpeed = 0;
    protected int currentBoardRow = 0;

    private void Awake()
    {
        spriteRenderer.sprite = enemyInfo.Sprite;
        movementSpeed = enemyInfo.MovementSpeed;
    }

    private void Start()
    {
        Invoke(nameof(Attack), enemyInfo.AttackSpeed);
    }

    private void Update()
    {
        transform.Translate(new Vector3(0, enemyInfo.MovementSpeed * Time.deltaTime * -1, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered enemy");
    }    
}
