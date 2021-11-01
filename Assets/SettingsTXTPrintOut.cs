using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsTXTPrintOut : MonoBehaviour
{
    public Text GPUAPIText, ResolutionText;

    void Start()
    {
        PrintOut();
    }

    void PrintOut()
    {
        ResolutionText.text = "Current Resolution: " + Screen.currentResolution.ToString();
        GPUAPIText.text = "Current Rendering API: " + SystemInfo.graphicsDeviceType.ToString();
    }
}
