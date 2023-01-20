using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterMove : GetterStat<MovementStat>
{
    [field: SerializeField] protected override MovementStat Stat { get; set; }
    public IMove GetMove() => new PlayerMovement(Stat.Rigidbody2D, new ReturnerControllableVector(Stat.Speed));
}
