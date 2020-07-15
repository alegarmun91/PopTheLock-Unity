using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedometerSliderUI : MonoBehaviour
{
    public Slider speedometerSlider;
    public GameData gameData;

    private void Start()
    {
        SetSpeedLimits(gameData.minMotorSpeed, gameData.maxMotorSpeed);
    }

    private void Update()
    {
        UpdateCurrentSpeed();
    }

    private void UpdateCurrentSpeed()
    {
        speedometerSlider.value = gameData.motorSpeed;
    }

    private void SetSpeedLimits(float min, float max)
    {
        speedometerSlider.maxValue = gameData.maxMotorSpeed;
        speedometerSlider.minValue = gameData.minMotorSpeed;
    }
    
    
}
