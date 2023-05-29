using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    [SerializeField] private float MinsToWin = 2;
    [SerializeField] private Image countdown_Img = null; 

    private float elapsedTime = 0;

    void Start()
    {
        GameStateController.ChangeGameState(GameStates.Play)
;        GameStateController.AddOnLoseAction(KillCountdown);
        StartCoroutine(DoCountdown());
    }

    private void KillCountdown()
    {
        StopAllCoroutines();
    }

    private IEnumerator DoCountdown()
    {
        while(elapsedTime < MinsToWin * 60)
        {
            ShowCountdownUIProgress();
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        //Do Win!
        GameStateController.ChangeGameState(GameStates.Win);
    }

    private void ShowCountdownUIProgress()
    {
        var progress = elapsedTime / (MinsToWin * 60);
        countdown_Img.fillAmount = progress;
    }
}
