using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDetector : MonoBehaviour
{
    public GameData gameData;
    public GameEvent dotMissedEvent;
    public GameEvent dotScoredEvent;
    
    private GameObject _currentDot;
    private GameObject _lastEnteredDot;
    private static bool DidTap => Input.GetMouseButtonDown((0));
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        _currentDot = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _lastEnteredDot = _currentDot;
        _currentDot = null;
    }

    private void Update()
    {
        if (!gameData.IsRunning) return;

        CheckIfMissedLastDot();
        
        if (!DidTap) return;
    
        if (_currentDot != null)
        {
            Destroy(_currentDot);
            dotScoredEvent.Raise();
        }
        else
        {
            dotMissedEvent.Raise();
        }
    }

    private void CheckIfMissedLastDot()
    {
        if (!_lastEnteredDot) return;
        
        if(DistanceFromLastDot() >= 0.3f)
            dotMissedEvent.Raise();
    }

    private float DistanceFromLastDot()
    {
        return (transform.position - _lastEnteredDot.transform.position).magnitude;
    }
}