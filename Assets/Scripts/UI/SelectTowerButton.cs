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

    public void Init(TowerInfoScriptableObject towerInfo, SelectedTowerReference selectedTowerReference)
    {
        this.towerInfo = towerInfo;
        this.selectedTowerReference = selectedTowerReference;

        name_TMP.text = this.towerInfo.Name;
        icon_Img.sprite = this.towerInfo.Icon;
    }

    
    public void Select()
    {
        selectedTowerReference.SetSelectedTower(towerInfo);
    }
}
