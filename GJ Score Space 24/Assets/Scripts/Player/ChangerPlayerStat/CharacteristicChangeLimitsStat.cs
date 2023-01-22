using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class CharacteristicChangeLimitsStat : Stat, ILimitOfAvableStatValue
{
    [field: SerializeField] public float MaximumValueOfStat { get; set; }
    [field: SerializeField] public float MinumnumValueOfStat { get; set; }

}
