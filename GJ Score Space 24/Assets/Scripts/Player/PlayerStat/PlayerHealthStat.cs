using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class PlayerHealthStat : Stat
{
  [field: SerializeField] public float Health { get; private set; }
  [field: SerializeField] public int ReloadTime { get; private set; }
}
