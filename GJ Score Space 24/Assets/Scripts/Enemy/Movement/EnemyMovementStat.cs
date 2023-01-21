using System;

using UnityEngine;

[Serializable]
public class EnemyMovementStat : Stat
{
    [field: SerializeField] public Rigidbody2D Rigidbody { get; private set; }
    [field: SerializeField] public Transform Target { get; private set; }

    [field: SerializeField] public float Speed { get; private set; }
    [field: SerializeField] public float AttackDistance { get; private set; }
    [field: SerializeField] public float RunOutDistance { get; private set; }
}