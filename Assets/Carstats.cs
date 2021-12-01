using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carstats : MonoBehaviour
{
    // Wheel names combo = none, solid, wingwheel, widewingwheel.
    // Wing name combo = none, 2_level.
    // Light name combo = none, standard_lights.
    public string Wheel = "solid", Wing = "none", Light = "none";
    // Paintshop available = red.
    public string paint = "red";
    // Owner
    public string owner = "Default";

    //Stats of the car. Set by the parts.
    private int speed = 1, traction = 1, HeadligtAreaLightup = 1;

    void Start()
    {
        LoadInSaveFile();
    }

    void LoadInSaveFile()
    {

    }

    void Update()
    {
        SetStats();
    }

    void SetStats()
    {
        int tractionBonus = 1;
        int lightBonus = 1;
        int speedBonus = 1;

        switch (Wheel)
        {
            case "solid":
                tractionBonus = tractionBonus;
                break;
            case "wingwheel":
                tractionBonus = tractionBonus + 2;
                break;
            case "widewingwheel":
                tractionBonus = tractionBonus + 3;
                speedBonus = speedBonus + 1;
                break;
            default:
                tractionBonus = tractionBonus - 1;
                break;
        }

        switch (Wing)
        {
            case "2_level":
                tractionBonus = tractionBonus + 1;
                break;
            default:
                break;
        }

        switch (Light)
        {
            case "standard_lights":
                lightBonus = lightBonus + 2;
                break;
            default:
                break;
        }

        speed = speedBonus;
        traction = tractionBonus;
        HeadligtAreaLightup = lightBonus;
    }

    public int GetSpeed()
    {
        return speed;
    }

    public int GetTraction()
    {
        return traction;
    }

    public int GetHeadligtAreaLightup()
    {
        return HeadligtAreaLightup;
    }
}
