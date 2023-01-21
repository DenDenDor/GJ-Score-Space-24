using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingByMouseButton : IAttack
{
    private readonly IAttack _attack;

    public ShootingByMouseButton(IAttack attack)
    {
        _attack = attack;
    }

    public void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _attack?.Attack();
        }
    }
}
