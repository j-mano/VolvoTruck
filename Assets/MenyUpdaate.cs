using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenyUpdaate : MonoBehaviour
{
    public Dropdown GraphicsLVLDropdown, ResulutionDropdown;
    public Toggle MusicToggle, VsyncToggle, WindowToggle;

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
        GraphicsLVLList();
        FillResulutionList();
    }

    void UpdateToggle()
    {

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

    public void setWindowd(){
        Screen.fullScreen = !Screen.fullScreen;
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

    void setVseync()
    {
        if (validateVsynon())
            QualitySettings.vSyncCount = 0;
        else
            QualitySettings.vSyncCount = 1;
    }

    bool validateVsynon()
    {
        if (QualitySettings.vSyncCount > 0)
            return true;
        else
            return false;
    }

    bool ValidateWindowd(){
        return !Screen.fullScreen;
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

    List<string> GetQualitySettingsName(){
        string[] name = QualitySettings.names;

        List<string> ListNames = new List<string>();

        foreach(string namee in name){
            ListNames.Add(namee);
        }

        return ListNames;
    }

    void GraphicsLVLList(){
        int qualityLevel = QualitySettings.GetQualityLevel();

        GraphicsLVLDropdown.ClearOptions();
        GraphicsLVLDropdown.AddOptions(GetQualitySettingsName());

        SetToCurrentGrafmode(qualityLevel);
    }

    void SetToCurrentGrafmode(int qualityLevel)
    {
        GraphicsLVLDropdown.value = QualitySettings.GetQualityLevel();
    }

    void FillResulutionList()
    {
        Resolution[] resolutions = Screen.resolutions;

        List<string> DropOptions = new List<string>();

        foreach (var res in resolutions)
        {
            ResulutionDropdown.ClearOptions();
            DropOptions.Add(res.ToString());
        }

        ResulutionDropdown.AddOptions(DropOptions);

        SetToCurrentResmode();
    }

    void SetToCurrentResmode()
    {
        ResulutionDropdown.value = ResulutionDropdown.options.FindIndex(option => option.text == Screen.currentResolution.ToString());
    }
}
