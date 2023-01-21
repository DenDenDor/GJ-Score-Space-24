using System.Collections;
using System;
using UnityEngine;

public class ImproverCharacteristic : IRaiserStat
{
    public float FactorOfImprovement { get; set; }
    public ImproverCharacteristic(float factorOfImprovement)
    {
        if (factorOfImprovement.IsEqualZero())
        {
            throw new InvalidOperationException();
        }
        FactorOfImprovement = factorOfImprovement;
    }

    public float ImpoveStat(float stat) => stat * FactorOfImprovement;
}
