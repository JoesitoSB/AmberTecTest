using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseTower : BaseCharacter
{
    [SerializeField] private SpriteRenderer spriteRenderer = null;
    [SerializeField] private TowerInfoScriptableObject towerInfo = null;
    protected float spawnCooldownTime = 0;
    //current board piece here

    private void Awake()
    {
        spriteRenderer.sprite = towerInfo.Sprite;
    }
}
