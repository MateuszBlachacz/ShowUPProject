using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "ScriptableObject/Event")]
public class GameEvent : ScriptableObject
{
    List<GameEventListenerAll> listeners = new List<GameEventListenerAll>();

    
    public void TriggerEvent()
    {
        for (int i = listeners.Count - 1 ; i >= 0; i--)
        {
            ((GameEventListener)listeners[i]).OnEventTriggered();
        }
    }
    
    public void TriggerEvent(float value)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            ((GameEventFloatListener)listeners[i]).OnEventTriggered(value);
        }
    }

    public void AddListener(GameEventListenerAll listener)
    {
        listeners.Add(listener);
    }

    public void RemoveListener(GameEventListenerAll listener)
    {
        listeners.Remove(listener);
    }
}
