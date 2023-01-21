using System;

using UnityEngine;

[Serializable]
public class EnemyRotationStat : Stat
{
    [field: SerializeField] public Transform Self { get; private set; }
    [field: SerializeField] public float Offset { get; private set; }
    [field: SerializeField] public Transform Target { get; private set; }
}