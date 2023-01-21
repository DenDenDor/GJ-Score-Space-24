using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackByTrigger : IAttack
{
    private IHavingHealth _havingHealth;
    private IReturnerHealth _returnerHealth;
    public AttackByTrigger(IHavingHealth havingHealth, IReturnerHealth returnerHealth)
    {
        _havingHealth = havingHealth;
        _returnerHealth = returnerHealth;
    }
    public void Attack()
    {
        _havingHealth.Health.ApplyDamage(_returnerHealth);
    }
}
