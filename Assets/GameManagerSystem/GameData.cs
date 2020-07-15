using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameData : ScriptableObject
{
    public int currentLevel;
    public int highestLevelReached = 0;
    public int dotsRemaining;
    
    public int livesRemaining;
    public int maxLives = 3;
    
    public float motorSpeed = 90;
    public float minMotorSpeed = 80;
    public float maxMotorSpeed = 165;
    public bool IsRunning { get; set; }

    public void ChangeSpeed(int value)
    {
        if (value != 0)
            motorSpeed += value;

        Mathf.Clamp(motorSpeed, minMotorSpeed, maxMotorSpeed);
    }
    
    public void LifeUp()
    {
        livesRemaining = Mathf.Clamp(livesRemaining+1, 0, maxLives);
    }

    public void LoseLife()
    {
        livesRemaining = Mathf.Clamp(livesRemaining-1, 0, maxLives);
    }
    
    public void ResetLevelData()
    {
        dotsRemaining = currentLevel;
    }

    public void ResetRunData()
    {
        livesRemaining = maxLives;
        currentLevel = 1;
        motorSpeed = minMotorSpeed;
        ResetLevelData();
    }
}
 