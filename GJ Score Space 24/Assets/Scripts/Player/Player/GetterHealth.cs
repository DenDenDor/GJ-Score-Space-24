using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterHealth : GetterStat<PlayerHealthStat>
{
    [field: SerializeField] protected override PlayerHealthStat Stat { get; set; }
    public Health Health { get; private set; }
    public IHealth GetHealth()
    {
        Health = new Health(Stat.Health);
        return new CoolDownForApplyingDamage(Stat.ReloadTime, Health);
    }
}
