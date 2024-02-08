using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoldManager : MonoBehaviour
{
    public float Gold {get; set;}

    [SerializeField]
    GameEvent goldChange;

    private void Awake()
    {
        
    }

    private void OnDestroy()
    {
        
    }

    public void AddGold(float gold)
    {
        
        Gold += gold;
        goldChange.TriggerEvent(Gold);
        Debug.Log(Gold);
    }

}
