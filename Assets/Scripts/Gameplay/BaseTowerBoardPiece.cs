using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTowerBoardPiece : BaseBoardPiece
{
    [SerializeField] private SelectedTowerReference selectedTowerReference = null;
    [SerializeField] private Canvas canvas = null;
    private BaseTower currentPlacedTower = null;
    private bool IsEmpty => currentPlacedTower == null;

    private BoardController boardController = null;

    private void Awake()
    {
        ShowCanvas(false);
    }

    public void Init(BoardController boardController)
    {
        this.boardController = boardController;
    }

    public void ShowCanvas(bool show)
    {
        if(IsEmpty) canvas.gameObject.SetActive(show);
    }

    public void PlaceSelectedTower()
    {
        boardController.ShowAvailableBoardPlaces(false);
        if (IsEmpty && selectedTowerReference.SelectedTower != null)
        {
            PlaceTower(selectedTowerReference.SelectedTower);
        }
    }

    private void PlaceTower(TowerInfoScriptableObject towerInfo)
    {
        
        if (currentPlacedTower == null)
        {
            var tower = Instantiate(towerInfo.Prefab, new Vector3(transform.position.x + GetSize().x / 2, transform.position.y - GetSize().y / 2, 0), Quaternion.Euler(0, 0, 90), transform).GetComponent<BaseTower>();
            currentPlacedTower = tower;            
        }
    }
}
