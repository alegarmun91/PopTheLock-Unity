using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private readonly List<EventListener> _eventListeners = new List<EventListener>();

    public void Raise()
    {
        foreach (var listener in _eventListeners)
        {
            listener.OnEventRaised();
        }
    }

    public void Register(EventListener listener)
    {
        if(!_eventListeners.Contains(listener))
            _eventListeners.Add(listener);
    }

    public void DeRegister(EventListener listener)
    {
        if (_eventListeners.Contains(listener))
            _eventListeners.Remove(listener);
    }
}