using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTowerBoardPiece : BaseBoardPiece
{
    [SerializeField] private SelectedTowerReference selectedTowerReference = null;
    [SerializeField] private Canvas canvas = null;
    private BaseTower currentPlacedTower = null;
    private bool IsEmpty => currentPlacedTower == null;

    private void Awake()
    {
        ShowCanvas(false);
    }

    public void ShowCanvas(bool show)
    {
        canvas.gameObject.SetActive(show);
    }

    public bool PlaceSelectedTower()
    {
        if(IsEmpty && selectedTowerReference.SelectedTower != null)
        {
            PlaceTower(selectedTowerReference.SelectedTower);
            return true;
        }

        return false;
    }

    private void PlaceTower(TowerInfoScriptableObject towerInfo)
    {
        if (currentPlacedTower == null)
        {
            var tower = Instantiate(towerInfo.Prefab, transform).GetComponent<BaseTower>();
            currentPlacedTower = tower;            
        }
    }
}
