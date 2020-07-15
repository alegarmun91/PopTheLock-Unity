using System;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public GameEvent[] events;
    public UnityEvent response;
    
    public void OnEventRaised()
    {
        response.Invoke();
    }

    private void OnEnable()
    {
        foreach (GameEvent eve in events)
        {
            eve.Register(this);
        }
    }

    private void OnDisable()
    {
        foreach (GameEvent eve in events)
        {
            eve.DeRegister(this);
        }
    }
}
