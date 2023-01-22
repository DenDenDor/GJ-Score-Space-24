using System.Collections;
using System;
using UnityEngine;

public class ImproverCharacteristic : IRaiserStat
{
    public float MaximumValueOfStat { get; set; }
    public float FactorOfImprovement { get; set; }
    public ImproverCharacteristic(float factorOfImprovement, float maximumValueOfStat)
    {
        if (factorOfImprovement.IsEqualZero())
        {
            throw new InvalidOperationException();
        }
        MaximumValueOfStat = maximumValueOfStat;
        FactorOfImprovement = factorOfImprovement;
    }

    public float ImpoveStat(float stat)
    {
        float maximumStat = MaximumValueOfStat;
        float improvedStat = stat * FactorOfImprovement;
        if (improvedStat < maximumStat)
        {
            maximumStat = improvedStat;
        }
       return maximumStat;
    }

}
