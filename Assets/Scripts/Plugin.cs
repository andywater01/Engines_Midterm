using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class Plugin : MonoBehaviour
{
    [DllImport("NativePlugin")]
    private static extern int RandomPosition(int num1, int num2, int randnum);


    // Start is called before the first frame update
    void Start()
    {
        int x = RandomPosition(0, 5, 0);
        int y = RandomPosition(0, 5, 0);
        int z = RandomPosition(0, 5, 0);
        this.gameObject.transform.localPosition = new Vector3(x, y, z);
    }

    
}
