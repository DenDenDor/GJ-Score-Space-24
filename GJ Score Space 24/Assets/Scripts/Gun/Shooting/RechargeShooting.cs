using System.Collections;
using System;
using UnityEngine;
using System.Threading;

public class RechargeShooting : IAttack
{
    private readonly int _fireRate;
    private bool _isCoolDown = true;
    private readonly IAttack _attack;
    public RechargeShooting(int fireRate, IAttack attack)
    {
        _fireRate = fireRate;
        _attack = attack;
    }

    public void Attack()
    {
        if (_isCoolDown)
        {
            Debug.Log("GEE");
            _attack?.Attack();
            CoolDown();
        }
    }
    private void CoolDown()
    {
        _isCoolDown = false;
        Timer timer = new Timer(Reload, null, _fireRate, Timeout.Infinite);
    }
    private void Reload(object obj)
    {
        _isCoolDown = true;
    }
}
