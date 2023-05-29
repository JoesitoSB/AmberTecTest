using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SelectTowerButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI name_TMP = null;
    [SerializeField] private Image icon_Img = null;

    private TowerInfoScriptableObject towerInfo = null;
    private SelectedTowerReference selectedTowerReference = null;
    private BoardController boardController = null;

    public void Init(TowerInfoScriptableObject towerInfo, SelectedTowerReference selectedTowerReference, BoardController boardController)
    {
        this.towerInfo = towerInfo;
        this.selectedTowerReference = selectedTowerReference;
        this.boardController = boardController;

        name_TMP.text = this.towerInfo.Name;
        icon_Img.sprite = this.towerInfo.Sprite;
    }

    
    public void Select()
    {
        selectedTowerReference.SetSelectedTower(towerInfo);
        boardController.ShowAvailableBoardPlaces(true);
    }
}
