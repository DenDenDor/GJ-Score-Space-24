using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterMove : GetterStat<MovementStat>
{
    [field: SerializeField] protected override MovementStat PlayerStat { get; set; }
    public IMove GetMove() => new PlayerMovement(PlayerStat.Rigidbody2D, new ReturnerControllableVector(PlayerStat.Speed));
}
