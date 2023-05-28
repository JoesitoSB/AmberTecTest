using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnTower : BaseTower
{
    protected override void Attack()
    {
        //shoot a bullet here. Maybe do part of the logic with an interface?
    }

    protected override void Die()
    {
        //Just die and notify the necesary script that this tower die
    }
}
