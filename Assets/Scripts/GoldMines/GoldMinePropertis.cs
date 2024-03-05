
using UnityEngine;

[CreateAssetMenu(fileName ="GoldMineProps", menuName ="ScriptableObject/GoldMineProps")]
public class GoldMinePropertis : ScriptableObject
{
    public int level=0;
    public float moneyProduced=0;
    public int speedProduction=2;
}
