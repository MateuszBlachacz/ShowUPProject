using UnityEngine;
using UnityEngine.Events;

public class GoldMain : MonoBehaviour
{
    [SerializeField]
    GoldMainPropertis info;


    public GameEvent goldGather;

    private void Awake()
    {
        InvokeRepeating("CallGoldEvent", 2, 2);
    }

    void CallGoldEvent()
    {
        goldGather.TriggerEvent(info.moneyProduced);
    }


}
