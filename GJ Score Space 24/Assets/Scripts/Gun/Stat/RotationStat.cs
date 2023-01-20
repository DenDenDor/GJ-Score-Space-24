using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class RotationStat : Stat
{
   [field:SerializeField]  public int Offset { get; private set; }
}
