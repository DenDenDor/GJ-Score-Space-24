using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GetterStat<T> : MonoBehaviour where T : PlayerStat
{
   protected abstract T PlayerStat { get; set; }
}
