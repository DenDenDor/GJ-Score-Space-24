using UnityEngine;

public class GetterEnemyMove : GetterStat<EnemyMovementStat>
{
    [field: SerializeField] protected override EnemyMovementStat Stat { get; set; }

    public IMove GetMove()
    {
        var returnerVector = new ReturnerEnemyVector(Stat.Speed, Stat.AttackDistance, Stat.RunOutDistance, transform, Stat.Target);
        
        return new EnemyMovement(Stat.Rigidbody, returnerVector);
    }
}