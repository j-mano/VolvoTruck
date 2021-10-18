using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{   
    Vector3 Carapos = new Vector3(0, 0, 0);

    void Start()
    {
        Carapos = this.transform.position;
    }

    void Update()
    {
        VerticalCheck();
    }

    void VerticalCheck()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if(Carapos.x > -6)
                Carapos = new Vector3(Carapos.x - 1, Carapos.y, Carapos.z);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (Carapos.x < 6)
                Carapos = new Vector3(Carapos.x + 1, Carapos.y, Carapos.z);
        }

        this.transform.position = Carapos;
    }
}
