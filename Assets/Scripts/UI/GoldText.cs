using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldText : MonoBehaviour
{

    public TextMeshProUGUI textGold;

    public void UpdateText(float value)
    {
        textGold.text = "Gold:" + value.ToString();
    }



}
