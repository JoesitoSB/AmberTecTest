using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToGameScene()
    {
        LoadScene(ScenesUtils.GameSceneName);
    }

    public void GoToMainMenuScene()
    {
        LoadScene(ScenesUtils.MainMenuSceneName);        
    }

    private void LoadScene(string sceneName)
    {
        GameStateController.ChangeGameState(GameStates.None);
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
    }
}
