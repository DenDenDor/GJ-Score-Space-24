using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class EnemyHealthStat : Stat
{
    [field: SerializeField] public float Health { get; private set; }
}
