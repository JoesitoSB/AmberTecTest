using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SelectTowerButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI name_TMP = null;
    [SerializeField] private Image icon_Img = null;
    [SerializeField] private Image cooldown_Img = null;

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
        cooldown_Img.fillAmount = 100;
        cooldown_Img.gameObject.SetActive(false);
    }

    
    public void Select()
    {
        selectedTowerReference.SetSelectedTower(towerInfo, this);
        boardController.ShowAvailableBoardPlaces(true);
    }

    public void StartCooldown()
    {
        cooldown_Img.fillAmount = 100;
        cooldown_Img.gameObject.SetActive(true);
        StartCoroutine(DoCooldown());
    }

    private IEnumerator DoCooldown()
    {
        float amountToDecreasePerSecond = 100 / towerInfo.SpawnCooldownTime;
        float amoundToDecreasePerMiliSecond = amountToDecreasePerSecond / 1000;
        while(cooldown_Img.fillAmount > 0)
        {
            cooldown_Img.fillAmount -= amoundToDecreasePerMiliSecond;
            yield return new WaitForSeconds(0.1f);

        }
        cooldown_Img.gameObject.SetActive(false);
        yield return null;
    }
}
