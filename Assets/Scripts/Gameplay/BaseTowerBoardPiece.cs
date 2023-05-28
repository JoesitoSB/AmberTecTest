using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTowerBoardPiece : BaseBoardPiece
{
    private BaseTower currentPlacedTower = null;

    public void PlaceTower(BaseTower newTower)
    {
        if (currentPlacedTower == null)
        {
            currentPlacedTower = newTower;
            //Do stuff
        }
    }
}
