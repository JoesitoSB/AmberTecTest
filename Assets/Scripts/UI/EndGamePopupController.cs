using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGamePopupController : MonoBehaviour
{
    [SerializeField] private GameObject popup;
    [SerializeField] private SceneSwitcher sceneSwitcher;
    [SerializeField] private TextMeshProUGUI title_TMP = null;
    private string winTitle = "You <color=green><b>win</b></color>!";
    private string loseTitle = "You <color=red><b>lose</b></color>!";

    private void Start()
    {
        GameStateController.AddOnWinAction(ShowWinScreen);
        GameStateController.AddOnLoseAction(ShowLoseScreen);
    }

    private void ShowWinScreen()
    {
        title_TMP.text = winTitle;
        popup.SetActive(true);
    }

    private void ShowLoseScreen()
    {
        title_TMP.text = loseTitle;
        popup.SetActive(true);
    }

    public void PlayAgain()
    {
        sceneSwitcher.GoToGameScene();
    }

    public void GoToMainMenu()
    {
        sceneSwitcher.GoToMainMenuScene();
    }

    private void OnDestroy()
    {
        GameStateController.RemoveOnWinAction(ShowWinScreen);
        GameStateController.RemoveOnLoseAction(ShowLoseScreen);
    }
}
