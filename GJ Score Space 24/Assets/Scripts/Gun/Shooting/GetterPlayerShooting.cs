using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterPlayerShooting : GetterStat<ShootingStat>, IChangableCharacteristic
{
    public Stat StartStat { get; set; }
    [field: SerializeField] public Changing—haracteristicStat Changing—haracteristicStat { get; set; }
    [field:SerializeField]  protected override ShootingStat Stat { get; set; }
    public IAttack GetAttack() => new ShootingByMouseButton(new RechargeShooting(Stat.FireRate, new GunShooting(Stat.Bullet, Stat.ShootPoint, Stat.Gun)));
    public IRaiserStat RaiserStat { get; set; }
    public Stat GetCurrentStat() => Stat;
    private void Awake() => RaiserStat = new ImproverCharacteristic(Changing—haracteristicStat.FactorOfChangingCharacteristic);
    public void ImproveStat()
    {
        Stat.FireRate = (int)RaiserStat.ImpoveStat(Stat.FireRate);
    }

    public void WorsenStat()
    {
    }
}
