using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class EnemyMiddleAttackStat : Stat
{
    [field: SerializeField] public Player Target { get; set; }
    [field: SerializeField] public float Range { get; set; } = 5;
}
