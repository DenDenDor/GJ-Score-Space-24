using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class HealthStat : Stat
{
  [field: SerializeField]   public float Health { get; private set; }

}
