using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterCameraStat : GetterStat<CameraStat>
{
  [field:SerializeField] protected override CameraStat Stat { get; set; }
  public IMove GetMove() => new MovementByChangingTransform(transform, new CameraMove(transform, Stat.Target,Stat.Speed));
}
