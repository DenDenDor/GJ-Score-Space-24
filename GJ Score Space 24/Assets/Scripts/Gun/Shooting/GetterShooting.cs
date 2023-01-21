using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterShooting : GetterStat<ShootingStat>
{
  [field:SerializeField]  protected override ShootingStat Stat { get; set; }
  public IAttack GetAttack() => new ShootingByMouseButton(new RechargeShooting(Stat.FireRate, new GunShooting(Stat.Bullet, Stat.ShootPoint, transform)));
}
