using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Use to make simple anmation of skybox
public class SkyManager : MonoBehaviour
{
    public bool bAnimatedSky;
    [SerializeField]
    float skySpeed;
    
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation",Time.time * skySpeed);
    }
}
