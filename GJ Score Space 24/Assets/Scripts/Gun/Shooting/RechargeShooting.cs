using System.Collections;
using System;
using UnityEngine;
using System.Threading;

public class RechargeShooting : IAttack
{
    private readonly int _fireRate;
    private readonly IAttack _attack;
    private readonly Recharger _recharger;
    public RechargeShooting(int fireRate, IAttack attack)
    {
        _fireRate = fireRate;
        _attack = attack;
        _recharger = new Recharger(_fireRate);
    }

    public void Attack()
    {
        if (_recharger.IsCoolDown)
        {
            _attack?.Attack();
            _recharger.CoolDown();
        }
    }

}
