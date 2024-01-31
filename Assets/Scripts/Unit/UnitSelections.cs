using System.Collections.Generic;
using UnityEngine;

public class UnitSelections : MonoBehaviour
{
    public List<GameObject> unitList = new List<GameObject>();
    public List<GameObject> unitsSelected = new List<GameObject>();

    private static UnitSelections _instance;
    public static UnitSelections Instance { get { return _instance; } }

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else
        {
            _instance = this;
        }
    }

    public void ClickSelect(GameObject unitToAdd)
    {
        DeselectAll();
        unitsSelected.Add(unitToAdd);
        UnitSelectionsGraphicUpdate(unitToAdd,true);
    }

    public void ShiftClickSelect(GameObject unitToAdd)
    {
        if (!unitsSelected.Contains(unitToAdd))
        {
            unitsSelected.Add(unitToAdd);
            UnitSelectionsGraphicUpdate(unitToAdd,true);
        } else
        {
            UnitSelectionsGraphicUpdate(unitToAdd,false);
            unitsSelected.Remove(unitToAdd);
            
        }
    }

    public void DragSelect(GameObject unitToAdd)
    {
        if (!unitsSelected.Contains(unitToAdd))
        {
            unitsSelected.Add(unitToAdd);
            UnitSelectionsGraphicUpdate(unitToAdd, true);
        }
    }

    public void DeselectAll()
    {
        foreach (var unit in unitsSelected)
        {
            UnitSelectionsGraphicUpdate(unit,false);
        }
        unitsSelected.Clear();

    }

    void UnitSelectionsGraphicUpdate(GameObject unit, bool setVisual)
    {
        
        for (int childId = 0; childId < unit.transform.childCount; childId++)
        {
            Transform child = unit.transform.GetChild(childId);
            if(child.gameObject.tag == "UnitSelectAnim")
            {
                child.gameObject.SetActive(setVisual);
            }

        }
     
    }

    public void Deselect(GameObject unitToDeselect)
    {

    }

}
