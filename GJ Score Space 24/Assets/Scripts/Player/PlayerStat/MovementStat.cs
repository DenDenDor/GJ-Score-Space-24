using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class MovementStat : PlayerStat
{
    [field: SerializeField] public Rigidbody2D Rigidbody2D { get; private set; }
    [field: SerializeField] public float Speed { get; private set; }
}

