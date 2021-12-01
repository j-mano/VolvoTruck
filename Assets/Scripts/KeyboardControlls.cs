using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardControlls : MonoBehaviour
{
    public GameObject Hiddenmeny;

    void Update()
    {
        ESCPresst();
        KeyboardPresst();
    }

    // Enter meny and pause
    void ESCPresst()
    {
        // Enter meny and pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseEnterMeny();
        }

        // Enter meny and pause
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseEnterMeny();
        }
    }

    void KeyboardPresst()
    {
        // Enter meny and pause
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            HideHidenmeny();
        }
    }

    void HideHidenmeny()
    {
        Hiddenmeny.SetActive(!Hiddenmeny.active);
    }

    void PauseEnterMeny()
    {

    }
}
