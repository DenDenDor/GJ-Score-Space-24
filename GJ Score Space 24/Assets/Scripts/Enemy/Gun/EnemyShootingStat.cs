using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class EnemyShootingStat : ShootingStat
{
    [field: SerializeField] public Transform Target { get; set; }
    [field: SerializeField] public float Range { get; set; } = 5;
}
