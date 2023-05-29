using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelectorController : MonoBehaviour
{
    [SerializeField] private BoardController boardController = null;
    [SerializeField] private List<TowerInfoScriptableObject> towerInfos = new List<TowerInfoScriptableObject>();
    [SerializeField] private SelectedTowerReference selectedTowerReference = null;
    [SerializeField] private GameObject selectTowerButton = null;

    private void Start()
    {
        foreach(var tower in towerInfos)
        {
            var towerButton = Instantiate(selectTowerButton, transform).GetComponent<SelectTowerButton>();
            towerButton.Init(tower, selectedTowerReference, boardController);
        }
    }

}
