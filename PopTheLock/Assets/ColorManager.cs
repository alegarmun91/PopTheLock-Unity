using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color loseColor;
    
    private Camera _camera;
    private Color _defaultColor;
    private void Start()
    {
        _camera = GetComponent<Camera>();
        _defaultColor = _camera.backgroundColor;
    }

    public void ChangeToLoseColor()
    {
        _camera.backgroundColor = loseColor;
    }

    public void ChangeToDefaultColor()
    {
        _camera.backgroundColor = _defaultColor;
    }
}
