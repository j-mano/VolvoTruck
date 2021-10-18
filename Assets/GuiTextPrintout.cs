using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuiTextPrintout : MonoBehaviour
{
    public Text FPSText,GPUAPIText,ScoreText,ResolutionText;

    private float fps = 0;

    // Start is called before the first frame update
    void Start()
    {
        staticPrintOut();
    }

    // Update is called once per frame
    void Update()
    {
        updatePrintout();
        FPSUpdate();
    }

    void updatePrintout()
    {
        FPSText.text = "Framerate: " + fps.ToString();
        ScoreText.text = "Current score: " + getScoreFromGame().ToString();
        ResolutionText.text = Screen.currentResolution.ToString();
    }

    void staticPrintOut()
    {
        GPUAPIText.text = SystemInfo.graphicsDeviceType.ToString();
    }

    int getScoreFromGame()
    {
        return 0;
    }

    void FPSUpdate()
    {
        fps = Time.frameCount / Time.time;
    }
}
