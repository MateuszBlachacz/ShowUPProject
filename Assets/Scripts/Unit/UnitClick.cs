using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UnitClick : MonoBehaviour
{
    private Camera myCam;
    
    public LayerMask clickable;
    public LayerMask groung;

    private UnitAction input; 

    private void Start()
    {
        myCam = Camera.main;
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Click");
            RaycastHit hit;
            Ray ray = myCam.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray.ToString());
            if (Physics.Raycast(ray: ray, hitInfo: out hit, Mathf.Infinity, clickable))
            {
                //Debug.Log("Hit clickable");
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    UnitSelections.Instance.ShiftClickSelect(hit.collider.gameObject);
                }
                else
                {
                    UnitSelections.Instance.ClickSelect(hit.collider.gameObject);
                }

            } else
            {
                if (!Input.GetKey(KeyCode.LeftShift))
                {
                    UnitSelections.Instance.DeselectAll();
                }
                
            }
        }
    }

}
