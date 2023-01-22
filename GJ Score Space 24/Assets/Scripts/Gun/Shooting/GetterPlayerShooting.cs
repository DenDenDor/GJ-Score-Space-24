using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterPlayerShooting : GetterStat<ShootingStat>, IChangerCharacteristic
{
    public Stat StartStat { get; set; }
    [field: SerializeField] public Changing�haracteristicStat Changing�haracteristicStat { get; set; }
    [field:SerializeField]  protected override ShootingStat Stat { get; set; }
    [field: SerializeField] public CharacteristicChangeLimitsStat CharacteristicChangeLimitsStat { get; set; }
    public IAttack GetAttack() => new ShootingByMouseButton(new RechargeShooting(Stat.FireRate, new GunShooting(Stat.Bullet, Stat.ShootPoint, Stat.Gun)));
    public IRaiserStat RaiserStat { get; set; }
    public IDegraderStat DegraderStat { get; set; }

    public Stat GetCurrentStat() => Stat;
    private void Awake()
    {
        DegraderStat = new WorseningCharacteristic(Changing�haracteristicStat.FactorOfChangingCharacteristic, CharacteristicChangeLimitsStat.MinumnumValueOfStat);
        RaiserStat = new ImproverCharacteristic(Changing�haracteristicStat.FactorOfChangingCharacteristic, CharacteristicChangeLimitsStat.MaximumValueOfStat);
    }
    public void ImproveStat() => Stat.FireRate = (int)DegraderStat.WorsenStat(Stat.FireRate);

    public void WorsenStat() => Stat.FireRate = (int)RaiserStat.ImpoveStat(Stat.FireRate);

    public float GetValueOfStat() => Stat.FireRate;
}
