using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TowerInfo", menuName = "ScriptableObjects/Tower Info")]
public class TowerInfoScriptableObject : ScriptableObject
{
    [SerializeField] private string name = "";
    [SerializeField] private Sprite sprite = null;
    [SerializeField] private GameObject prefab = null;
    [SerializeField] private float damage = 0;
    [SerializeField] private float health = 0;
    [SerializeField] private float range = 0;
    [SerializeField] private float attackSpeed = 0;
    [SerializeField] private float spawnCooldownTime = 0;


    public string Name => name;
    public Sprite Sprite => sprite;
    public GameObject Prefab => prefab;
    public float Damage => damage;
    public float Health => health;
    public float Range => range;
    public float AttackSpeed => attackSpeed;
    public float SpawnCooldownTime => spawnCooldownTime;
}
