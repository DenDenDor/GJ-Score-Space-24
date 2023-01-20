using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class MovementStat : Stat
{
    [field: SerializeField] public Rigidbody2D Rigidbody2D { get; private set; }
    [field: SerializeField] public float Speed { get; private set; }
}

