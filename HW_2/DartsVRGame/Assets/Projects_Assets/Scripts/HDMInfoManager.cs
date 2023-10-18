using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class HDMInfoManager : MonoBehaviour
{
    void Start()
    {
        CheckActiveDevice();
    }

    void Update()
    {
        
    }

    void CheckActiveDevice()
    {
        Debug.Log("Is device active " + XRSettings.isDeviceActive);
        Debug.Log("Device name: " + XRSettings.loadedDeviceName);

        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No headset plugged");
        }
        else if (XRSettings.isDeviceActive && XRSettings.loadedDeviceName == "MockHMD Display")
        {
            Debug.Log("Using Mock HDM display");
        }
        else
        {
            Debug.Log("We are rich and have a headset named " + XRSettings.loadedDeviceName);
        }
    }
}
