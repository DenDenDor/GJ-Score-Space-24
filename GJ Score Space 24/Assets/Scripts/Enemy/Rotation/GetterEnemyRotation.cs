using UnityEngine;

public class GetterEnemyRotation : GetterStat<EnemyRotationStat>
{
    [field: SerializeField] protected override EnemyRotationStat Stat { get; set; }

    public IRotation GetRotation() => new EnemyRotation(Stat.Self, new ReturnerEnemyRotation(Stat.Offset, Stat.Self, Stat.Target));
}