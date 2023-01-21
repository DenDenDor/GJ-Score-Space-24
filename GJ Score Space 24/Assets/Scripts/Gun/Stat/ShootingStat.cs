using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class ShootingStat : Stat
{
    [field: SerializeField] public Bullet Bullet { get; private set; }
    [field: SerializeField] public int FireRate { get; private set; }
    [field: SerializeField] public Transform ShootPoint { get; private set; }
}
