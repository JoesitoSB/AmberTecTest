using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBoardPiece : BaseBoardPiece
{
    [SerializeField] private List<EnemyInfoScriptableObject> enemiesToSpawn = new List<EnemyInfoScriptableObject>();
    private float spawnRate = 0;

    private void Awake()
    {      
        Invoke(nameof(Spawn), Random.Range(5, 12));
    }

    private void Spawn()
    {
        int enemyIndex = Random.Range(0, enemiesToSpawn.Count - 1);
        Instantiate(enemiesToSpawn[enemyIndex].Prefab, new Vector3(transform.position.x + GetSize().x / 2, transform.position.y - GetSize().y / 2, 0), Quaternion.Euler(0, 0, -90), transform);
        Invoke(nameof(Spawn), Random.Range(45, 120));
    }
}
