using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowManager : MonoBehaviour
{
    private List<GameObject> PowList;

    public List<GameObject> GetList()
    {
        return PowList;
    }

    public void AddToList(GameObject Pow)
    {
        PowList.Add(Pow);
    }
}
