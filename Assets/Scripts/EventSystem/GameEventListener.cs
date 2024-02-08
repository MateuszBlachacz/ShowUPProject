using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent gameEvent;
    public UnityEvent onEventTriggered;
    public UnityFloatEvent onEventFloatTriggerd;

    private void OnEnable()
    {
        gameEvent.AddListener(this);
    }

    private void OnDisable()
    {
        gameEvent.RemoveListener(this);
    }

    public void OnEventTriggered()
    {
        onEventTriggered.Invoke();
    }

    public void OnEventTriggered(float value)
    {
        onEventFloatTriggerd.Invoke(value);
    }

}
[System.Serializable]
public class UnityFloatEvent : UnityEvent<float> { }
