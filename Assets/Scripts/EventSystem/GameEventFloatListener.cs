using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventFloatListener : GameEventListenerAll
{
    [SerializeField]
    UnityFloatEvent onEventFloatTriggerd;

    public void OnEventTriggered(float value)
    {
        onEventFloatTriggerd.Invoke(value);
    }

}

