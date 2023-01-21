using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterMove : GetterStat<RigidbodyMovementStat>
{
    [field: SerializeField] protected override RigidbodyMovementStat Stat { get; set; }
    public IMove GetMove() => new PlayerMovement(Stat.Rigidbody2D, new ReturnerControllableVector(Stat.Speed));
}
