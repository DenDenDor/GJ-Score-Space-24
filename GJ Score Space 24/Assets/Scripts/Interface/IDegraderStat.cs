using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDegraderStat
{
    public float WorsenStat(float stat);
    public float MinumnumValueOfStat { get; set; }
}
