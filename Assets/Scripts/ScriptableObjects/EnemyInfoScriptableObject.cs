using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyInfo", menuName = "ScriptableObjects/Enemy Info")]
public class EnemyInfoScriptableObject : CharacterInfoScriptableObject
{
    [SerializeField] private float movementSpeed = 0;

    public float MovementSpeed => movementSpeed;
}
