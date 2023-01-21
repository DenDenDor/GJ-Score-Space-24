using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : IAttack
{
    private IRotation _rotation;
    private IAttack _attack;

    public Gun(IRotation rotation, IAttack attack)
    {
        _rotation = rotation;
        _attack = attack;
    }

    public void Attack()
    {
        _rotation?.Rotate();
        _attack?.Attack();
    }

}
