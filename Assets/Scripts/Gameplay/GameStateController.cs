using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStateController
{
    private static GameStates currentGameState = GameStates.None;
    private static GameStates lastGameState = GameStates.None;
    public static GameStates GetCurrentState => currentGameState;

    public delegate void onStateChange();
    private static onStateChange onPlay;
    private static onStateChange onWin;
    private static onStateChange onLose;

    public static void ChangeGameState(GameStates gameState)
    {
        lastGameState = currentGameState;
        currentGameState = gameState;

        switch(gameState)
        {
            case GameStates.Play:
                onPlay?.Invoke();
                break;
            case GameStates.Win:
                onWin?.Invoke();
                break;
            case GameStates.Lose:
                onLose?.Invoke();
                break;
        }
    }

    public static void AddOnPlayAction(onStateChange onPlay)
    {
        GameStateController.onPlay += onPlay;
    }

    public static void RemoveOnPlayAction(onStateChange onPlay)
    {
        GameStateController.onPlay -= onPlay;
    }

    public static void AddOnWinAction(onStateChange onWin)
    {
        GameStateController.onWin += onWin;
    }

    public static void RemoveOnWinAction(onStateChange onWin)
    {
        GameStateController.onWin -= onWin;
    }

    public static void AddOnLoseAction(onStateChange onLose)
    {
        GameStateController.onLose += onLose;
    }

    public static void RemoveOnLoseAction(onStateChange onLose)
    {
        GameStateController.onLose -= onLose;
    }
}
