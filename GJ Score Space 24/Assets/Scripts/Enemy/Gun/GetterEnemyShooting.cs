using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterEnemyShooting : GetterStat<EnemyShootingStat>
{
    [field: SerializeField] protected override EnemyShootingStat Stat { get; set; }
    public IAttack GetAttack() => new AttackingByApproach(transform, Stat.Target, Stat.Range, new RechargeShooting(Stat.FireRate, new GunShooting(Stat.Bullet, Stat.ShootPoint, Stat.Gun)));

}
