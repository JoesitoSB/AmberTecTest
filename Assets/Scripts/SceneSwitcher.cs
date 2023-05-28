using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject loadingSceneScreen = null;

    public void GoToGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(ScenesUtils.GameSceneName);
        //Show loading screen
    }

    public void GoToMainMenuScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(ScenesUtils.MainMenuSceneName);
        //Show loading screen
    }
}
