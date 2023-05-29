using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : BaseCharacter
{
    [SerializeField] protected EnemyInfoScriptableObject enemyInfo = null;
    private Camera mainCamera = null;
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
        if (GameStateController.GetCurrentState != GameStates.Play)
            return;

        transform.Translate(new Vector3(0, enemyInfo.MovementSpeed * Time.deltaTime * -1, 0));


        var screenPoint = mainCamera.WorldToViewportPoint(transform.position);

        if(screenPoint.x < 0 || screenPoint.y < 0 || screenPoint.z < 0)//Out of screen
        {
            GameStateController.ChangeGameState(GameStates.Lose);
        }
    }

    public void AssignCamera(Camera camera)
    {
        mainCamera = camera;
    }
}
