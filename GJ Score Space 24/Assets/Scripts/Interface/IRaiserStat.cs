using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRaiserStat
{
    public float MaximumValueOfStat { get; set; }
    public float ImpoveStat(float stat);
}
