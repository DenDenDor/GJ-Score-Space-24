using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterMiddleAttack : GetterStat<EnemyMiddleAttackStat>, IGetterAttack
{
    [field: SerializeField] protected override EnemyMiddleAttackStat Stat { get; set; }
    [SerializeField] private GetterDamage _getterDamage;
    public IAttack GetAttack() => new AttackingByApproach(transform, Stat.Target.transform, Stat.Range, new AttackByTrigger(Stat.Target,_getterDamage.GetReturnerHealth()));

}
