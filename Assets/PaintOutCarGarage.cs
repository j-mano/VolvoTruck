using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintOutCarGarage : MonoBehaviour
{
    string Wheel = "solid", Wing = "none", Light = "none";
    // Paintshop available = red.
    string paint = "red";

    // Cardparts in the scene
    // CarBases and paintjobs
    public GameObject RedPaintedBase;// BluePaintedBase, BlackPaintedBase;
    // Wheels
    public GameObject SolidWheels, WingWheel, WideWingWheel;
    // Lights
  /*  public GameObject StandarsLights;
    // Wing
    public GameObject DualWing;*/

    // The cars stats and parts
    public GameObject stats;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        readoffstats();
        LoadInBase();
        LoadInAcessiores();
    }

    void readoffstats()
    {
        paint = stats.GetComponent<Carstats>().paint;
        Wheel = stats.GetComponent<Carstats>().Wheel;
        Light = stats.GetComponent<Carstats>().Light;
        Wing  = stats.GetComponent<Carstats>().Wing;
    }

    // Loading in base of the car. Setting the paint of the car.
    void LoadInBase()
    {
        // Default paint should be red.
        switch (paint)
        {
            /*case "black":
                RedPaintedBase.SetActive(false);
                BluePaintedBase.SetActive(false);
                BlackPaintedBase.SetActive(true);
                break;
            case "blue":
                RedPaintedBase.SetActive(false);
                BluePaintedBase.SetActive(true);
                BlackPaintedBase.SetActive(false);
                break;*/
            default:
                RedPaintedBase.SetActive(true);
               // BluePaintedBase.SetActive(false);
               // BlackPaintedBase.SetActive(false);
                break;
        }
    }

    void LoadInAcessiores()
    {

        switch (Wheel)
        {
            case "solid":
                Debug.Log(Wheel);
                SolidWheels.SetActive(true);
                WingWheel.SetActive(false);
                WideWingWheel.SetActive(false);
                break;
            case "wingwheel":
                SolidWheels.SetActive(false);
                WingWheel.SetActive(true);
                WideWingWheel.SetActive(false);
                break;
            case "widewingwheel":
                SolidWheels.SetActive(false);
                WingWheel.SetActive(false);
                WideWingWheel.SetActive(true);
                break;
            default:
                SolidWheels.SetActive(false);
                WingWheel.SetActive(false);
                WideWingWheel.SetActive(false);
                break;
        }

        /*switch (Wing)
        {
            case "2_level":
                DualWing.SetActive(true);
                break;
            default:
                DualWing.SetActive(false);
                break;
        }

        switch (Light)
        {
            case "standard_lights":
                StandarsLights.SetActive(true);
                break;
            default:
                StandarsLights.SetActive(false);
                break;
        }*/
    }
}
