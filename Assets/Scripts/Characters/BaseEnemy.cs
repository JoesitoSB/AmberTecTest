using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : BaseCharacter
{
    protected float movementSpeed = 0;
    protected int currentBoardRow = 0;
    protected abstract void Move();
}
