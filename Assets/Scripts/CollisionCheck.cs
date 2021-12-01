using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    // Size X, Y
    float[] Size = {2f, 2f};

    public GameObject GameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckCollidePow();
        CheckCollideObsticales();
    }

    public float[] GetCarSize()
    {
        return Size;
    }

    void CheckCollidePow()
    {
        List<GameObject> PowList = GameObject.GetComponent<PowManager>().GetList();

        foreach (GameObject Pow in PowList)
        {
            GetCarSize();
        }
    }

    void CheckCollideObsticales()
    {
        List<GameObject> ObjectList = GameObject.GetComponent<ObsticalesManager>().GetList();

        foreach(GameObject Obsticale in ObjectList)
        {
            GetCarSize();
        }
    }
}
