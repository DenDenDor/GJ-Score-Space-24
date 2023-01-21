using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class CameraStat : Stat
{
    [field: SerializeField] public float Speed { get; private set; }
    [field: SerializeField] public Transform Target { get; private set; }

}
