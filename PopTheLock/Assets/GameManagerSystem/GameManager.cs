using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData gameData;
    public Animator lockAnimator;
    public GameEvent onWinEvent;

    private bool _isFirstTap = true;
    
    private void Awake()
    {
        gameData.ResetLevelData();
    }

    private void Start()
    {
        SetNewRun();
    }

    private void Update()
    {
        if (!(lockAnimator.GetCurrentAnimatorStateInfo(0).IsName("Idle")) || !_isFirstTap)
            return;
        
        if(Input.GetMouseButtonUp(0) && !gameData.IsRunning)
            StartTry();
    }

    private void StartTry()
    {
        gameData.IsRunning = true;
        _isFirstTap = false;
    }

    public void DecrementRemainingDots()
    {
        gameData.dotsRemaining--;

        if (gameData.dotsRemaining <= 0)
        {
            gameData.dotsRemaining = 0;
            onWinEvent.Raise();
        }
    }

    public void LoadLevel(bool nextLevel)
    {
        if (nextLevel) gameData.currentLevel++;
        gameData.ResetLevelData();
        _isFirstTap = true;
    }

    public void StopGame()
    {
        gameData.IsRunning = false;
    }
    
    public void ResetLevel()
    {
        gameData.IsRunning = false;
        gameData.ResetLevelData();
    }

    public void CheckLivesRemaining()
    {
        if(gameData.livesRemaining<=0)
            SetNewRun();
    }

    private void SetNewRun()
    {
        StopGame();
        gameData.ResetRunData();
    }
}
