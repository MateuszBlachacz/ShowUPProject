using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : GameEventListenerAll
{ 
    [SerializeField]
    UnityEvent onEventTriggered;
    
    public void OnEventTriggered()
    {
        onEventTriggered.Invoke();
    }
}


