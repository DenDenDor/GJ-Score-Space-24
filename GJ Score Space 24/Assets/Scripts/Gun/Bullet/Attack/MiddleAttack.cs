using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleAttack : IAttack
{
    private IHavingHealth _havingHealth;
    private IReturnerHealth _returnerHealth;
    public MiddleAttack(IHavingHealth havingHealth, IReturnerHealth returnerHealth)
    {
        _havingHealth = havingHealth;
        _returnerHealth = returnerHealth;
    }
    public void Attack()
    {
        _havingHealth.Health.ApplyDamage(_returnerHealth);
    }
}
