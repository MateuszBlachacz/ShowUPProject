using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class GoldMain : MonoBehaviour
{
    [SerializeField]
    GoldMainPropertis info;
    [SerializeField]
    TextMeshProUGUI GoldText;

    public GameEvent goldGather;
    

    private void Awake()
    {
        InvokeRepeating("CallGoldEvent", 2, info.speedProduction);
        GoldText.text = info.moneyProduced.ToString();
    }

    void CallGoldEvent()
    {
        goldGather.TriggerEvent(info.moneyProduced);
    }


}
