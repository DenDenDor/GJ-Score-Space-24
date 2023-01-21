using System.Collections;
using System;
using UnityEngine;
public abstract class MovementStat : Stat
{
   [field: SerializeField] public float Speed { get; set; }
}

