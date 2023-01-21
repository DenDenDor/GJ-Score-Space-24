using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterBulletMovement : GetterStat<TransformMovementStat>
{
    [field:SerializeField] protected override TransformMovementStat Stat { get; set; }
    public IMove GetMove() => new MovementByTranslate(transform, new ReturnerStraightVector(Stat.Speed));
}
