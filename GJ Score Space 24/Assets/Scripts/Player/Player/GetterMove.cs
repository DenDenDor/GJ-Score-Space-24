using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterMove : GetterStat<RigidbodyMovementStat>, IChangerCharacteristic
{
    public Stat StartStat { get; set; }
    [field: SerializeField] public ChangingÑharacteristicStat ChangingÑharacteristicStat { get; set; }
    [field: SerializeField] protected override RigidbodyMovementStat Stat { get; set; }
    [field: SerializeField] public CharacteristicChangeLimitsStat CharacteristicChangeLimitsStat { get; set; }
    public IRaiserStat RaiserStat { get; set; }
    public IDegraderStat DegraderStat { get; set; }

    public IMove GetMove() => new PlayerMovement(Stat.Rigidbody2D, new ReturnerControllableVector(Stat.Speed));
    public Stat GetCurrentStat() => Stat;
    private void Awake()
    {
        RaiserStat = new ImproverCharacteristic(ChangingÑharacteristicStat.FactorOfChangingCharacteristic,CharacteristicChangeLimitsStat.MaximumValueOfStat);
        DegraderStat = new WorseningCharacteristic(ChangingÑharacteristicStat.FactorOfChangingCharacteristic, CharacteristicChangeLimitsStat.MinumnumValueOfStat);
    }
    public void WorsenStat()
    {
        Stat.Speed = DegraderStat.WorsenStat(Stat.Speed);
    }
    public void ImproveStat()
    {
        Stat.Speed = RaiserStat.ImpoveStat(Stat.Speed);
    }

    public float GetValueOfStat() => Stat.Speed;
}