using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class RigidbodyMovementStat : MovementStat
{
    [field: SerializeField] public Rigidbody2D Rigidbody2D { get; private set; }
}
