using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class GameEventListenerAll : MonoBehaviour
{
    public GameEvent gameEvent;

    protected void OnEnable()
    {
        gameEvent.AddListener(this);
    }

    protected void OnDisable()
    {
        gameEvent.RemoveListener(this);
    }

}
[System.Serializable]
public class UnityFloatEvent : UnityEvent<float> { }
