using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalesManager : MonoBehaviour
{
    private List<GameObject> ObjectList;

    public List<GameObject> GetList()
    {
        return ObjectList;
    }

    public void AddToList(GameObject Object)
    {
        ObjectList.Add(Object);
    }
}
