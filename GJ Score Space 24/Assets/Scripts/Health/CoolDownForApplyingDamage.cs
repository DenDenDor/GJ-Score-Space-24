using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDownForApplyingDamage : IHealth
{
    private IHealth _health;
    private readonly Recharger _recharger;
    public CoolDownForApplyingDamage(int reloadTime, IHealth health)
    {
        _health = health;
        _recharger = new Recharger(reloadTime);
    }
    public void ApplyDamage(IReturnerHealth returnerHealth)
    {
        if (_recharger.IsCoolDown)
        {
            _health?.ApplyDamage(returnerHealth);
            _recharger.CoolDown();
        }
    }
}
