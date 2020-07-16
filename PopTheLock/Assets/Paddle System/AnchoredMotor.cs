using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnchoredMotor : MonoBehaviour
{
    public Direction direction = Direction.Clockwise;
    public GameData gameData;
    public GameEvent onPaddleReset;
    
    private Transform _anchor;
    private Vector3 _initialPosition;
    private static bool DidTap => Input.GetMouseButtonDown((0));

    private void Start()
    {
        _anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
        _initialPosition = transform.localPosition;
    }

    private void Update()
    {
        if (!gameData.IsRunning) return;
        
        transform.RotateAround(_anchor.position, 
            Vector3.forward, gameData.motorSpeed * Time.deltaTime * (int) direction);
        
        if (DidTap)
        {
            ChangeDirection();
        }
    }

    private void ChangeDirection()
    {
        switch (direction)
        {
            case Direction.Clockwise:
                direction = Direction.Anticlockwise;
                break;
            case Direction.Anticlockwise:
                direction = Direction.Clockwise;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void ResetPosition()
    {
        Transform myTransform = transform;
        myTransform.localPosition = new Vector3(0, _initialPosition.y, 0);
        myTransform.rotation = Quaternion.identity;
        
        onPaddleReset.Raise();
    }

    public enum Direction
    {
        Clockwise = -1,
        Anticlockwise = 1
    }
}
