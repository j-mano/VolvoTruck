using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenyUpdaate : MonoBehaviour
{
    public Dropdown GraphicsLVLDropdown;
    public Dropdown ResulutionDropdown;
    public Toggle MusicToggle;
    public Toggle VsyncToggle;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDroppDownSettings();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateToggle();
    }

    void UpdateDroppDownSettings()
    {

    }

    void UpdateToggle()
    {
        MusicToggle.isOn = ValidateMusicOn();
        VsyncToggle.isOn = validateVsynon();
    }


    // Input from UI

    public void VsyncToggleSignal()
    {
        setVseync();
    }

    public void MusikToggleSignal()
    {
        SetMusik();
    }

    public void MusikVolumSliderSignal(float Volum)
    {
        SetMusik();
    }

    public void SetResultionSignal()
    {

    }

    public void SetGrapichslvlSignal(int GraphicsLVL)
    {
        setGraphicalLVL(GraphicsLVL);
    }

    // Functions after this line

    void GetAvaliableResulution()
    {

    }

    int GetAvaliableGraphicsLVLS()
    {
        return QualitySettings.GetQualityLevel();
    }

    /// <summary>
    /// Allowd input 0(Low) 1(High) and 2(Very High);
    /// </summary>
    /// <param name="graphicsLVL">Graphics lvl.</param>
    void setGraphicalLVL(int graphicsLVL)
    {
        QualitySettings.SetQualityLevel(graphicsLVL, true);
    }

    bool validateVsynon()
    {
        if (QualitySettings.vSyncCount > 0)
            return true;
        else
            return false;
    }

    void setVseync()
    {
        if (validateVsynon())
            QualitySettings.vSyncCount = 0;
        else
            QualitySettings.vSyncCount = 1;
    }

    bool ValidateMusicOn()
    {
        return true;
    }

    void SetMusik()
    {

    }

    void SetVolum()
    {
        // Implement Cokie system.
    }
}
