using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SelectedTowerReference", menuName = "ScriptableObjects/Selected Tower Reference" )]
public class SelectedTowerReference : ScriptableObject
{
    public TowerInfoScriptableObject SelectedTower { private set; get; }
    public SelectTowerButton SelectedTowerButton { private set; get; }

    public void SetSelectedTower(TowerInfoScriptableObject tower, SelectTowerButton selectedTowerButton)
    {
        SelectedTower = tower;
        SelectedTowerButton = selectedTowerButton;
    }
}
