using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    int Score, Lifes, MilesTravels;

    public int GetLifes()
    {
        return Lifes;
    }

    public int GetScores()
    {
        return Score;
    }

    public int GetMilesTraveld()
    {
        return MilesTravels;
    }
}
