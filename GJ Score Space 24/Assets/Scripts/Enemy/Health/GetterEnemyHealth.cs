using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterEnemyHealth : GetterStat<EnemyHealthStat>
{
    [field:SerializeField] protected override EnemyHealthStat Stat { get; set; }
    public IHealth GetHealth() => new Health(Stat.Health);
}
