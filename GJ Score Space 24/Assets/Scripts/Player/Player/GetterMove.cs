using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterMove : GetterStat<RigidbodyMovementStat>, IChangableCharacteristic
{
    public Stat StartStat { get; set; }
    [field: SerializeField] public Changing—haracteristicStat Changing—haracteristicStat { get; set; }
    [field: SerializeField] protected override RigidbodyMovementStat Stat { get; set; }
    public IRaiserStat RaiserStat { get; set; }

    public IMove GetMove() => new PlayerMovement(Stat.Rigidbody2D, new ReturnerControllableVector(Stat.Speed));
    public Stat GetCurrentStat() => Stat;
    private void Awake() => RaiserStat = new ImproverCharacteristic(Changing—haracteristicStat.FactorOfChangingCharacteristic);
    public void WorsenStat()
    {
        throw new System.NotImplementedException();
    }

    public void ImproveStat()
    {
        throw new System.NotImplementedException();
    }
}
