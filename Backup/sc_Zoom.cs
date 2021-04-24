using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_Zoom : ModTool.Interface.ModBehaviour
{
    private void Update()
    {
        bool IsPressing = Input.GetKey(KeyCode.Z);
        if (IsPressing) Camera.main.fieldOfView = 35; else Camera.main.fieldOfView = 60;

    }
}
