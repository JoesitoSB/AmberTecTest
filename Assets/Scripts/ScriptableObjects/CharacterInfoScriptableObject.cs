using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterInfoScriptableObject : ScriptableObject
{
    [SerializeField] protected Sprite sprite = null;
    [SerializeField] protected GameObject prefab = null;
    [SerializeField] protected float damage = 0;
    [SerializeField] protected float health = 0;
    [SerializeField] protected float range = 0;
    [SerializeField] protected float attackSpeed = 0;
    [SerializeField] protected float bulletSpeed = 0;
    [SerializeField] protected GameObject bulletsPrefab = null;

    public Sprite Sprite => sprite;
    public GameObject Prefab => prefab;
    public float Damage => damage;
    public float Health => health;
    public float Range => range;
    public float AttackSpeed => attackSpeed;
    public float BulletSpeed => bulletSpeed;
    public GameObject BulletsPrefab => bulletsPrefab;
}