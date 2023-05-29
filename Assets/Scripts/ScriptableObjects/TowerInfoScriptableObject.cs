using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TowerInfo", menuName = "ScriptableObjects/Tower Info")]
public class TowerInfoScriptableObject : CharacterInfoScriptableObject
{
    [SerializeField] private string name = "";
    [SerializeField] private float spawnCooldownTime = 0;


    public string Name => name;
    public float SpawnCooldownTime => spawnCooldownTime;
}
