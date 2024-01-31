using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAnimation : MonoBehaviour
{
    float minsize = 0.9f;
    float maxsize = 1.2f;
    float chVal = 0.15f;

    void Update()
    {
        Vector3 changescale = new Vector3(changedValue(), 0, chVal);
        transform.localScale += changescale * Time.deltaTime;
    }

    float changedValue()
    {
        if (transform.localScale.x <= minsize) chVal *= -1;
        if (transform.localScale.x >= maxsize) chVal *= -1;
        return chVal;
    }
}
