using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterDamage : GetterStat<DamageStat>
{
  [field:SerializeField]  protected override DamageStat Stat { get; set; }
    public IReturnerHealth GetReturnerHealth() => new DecreaserHealth(Stat.Damage);
}
