using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBoardPiece : BaseBoardPiece
{
    [SerializeField] private List<EnemyInfoScriptableObject> enemiesToSpawn = new List<EnemyInfoScriptableObject>();
    [SerializeField] private Camera mainCamera = null;

    private void Awake()
    {      
        Invoke(nameof(Spawn), Random.Range(5, 12));
    }

    private void Spawn()
    {
        if (GameStateController.GetCurrentState != GameStates.Play) return;

        int enemyIndex = Random.Range(0, enemiesToSpawn.Count - 1);
        var enemy = Instantiate(enemiesToSpawn[enemyIndex].Prefab, new Vector3(transform.position.x + GetSize().x / 2, transform.position.y - GetSize().y / 2, 0), Quaternion.Euler(0, 0, -90), transform).GetComponent<BaseEnemy>();
        enemy.AssignCamera(mainCamera);
        Invoke(nameof(Spawn), Random.Range(45, 120));
    }

    public void AssignCamera(Camera camera)
    {
        mainCamera = camera;
    }

}
