using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterHealth : GetterStat<HealthStat>
{
    [field: SerializeField] protected override HealthStat Stat { get; set; }
    public Health GetHealth() => new Health(Stat.Health);
}
