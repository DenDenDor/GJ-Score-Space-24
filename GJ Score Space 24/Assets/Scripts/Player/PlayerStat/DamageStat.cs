using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class DamageStat : Stat
{
 [field:SerializeField] public float Damage { get; private set; }
}
