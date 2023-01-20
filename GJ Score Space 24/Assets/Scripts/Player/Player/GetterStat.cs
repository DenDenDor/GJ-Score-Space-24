using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GetterStat<T> : MonoBehaviour where T : Stat
{
   protected abstract T Stat { get; set; }
}
