using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorseningCharacteristic : IDegraderStat
{
    public float FactorOfImprovement { get; set; }
    public float MinumnumValueOfStat { get; set; }
    public WorseningCharacteristic(float factorOfImprovement, float minumnumValueOfStat)
    {
        FactorOfImprovement = factorOfImprovement;
        MinumnumValueOfStat = minumnumValueOfStat;
    }
    public float WorsenStat(float stat)
    {
        float minumumStat = MinumnumValueOfStat;
        float degradedStat = stat / FactorOfImprovement;
        if (degradedStat > minumumStat)
        {
            degradedStat = minumumStat;
        }
        return minumumStat;
    }
}
