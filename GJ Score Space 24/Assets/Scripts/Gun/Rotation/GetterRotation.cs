using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterRotation : GetterStat<RotationStat>
{
   [field: SerializeField] protected override RotationStat Stat { get; set; }
    public IRotation GetRotation() => new GunRotation(transform, new ReturnerGunRotation(transform, Stat.Offset));
}
