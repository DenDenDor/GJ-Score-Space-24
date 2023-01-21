using System.Collections;
using System;
using UnityEngine;

public class DecreaserHealth : IReturnerHealth
{
    private float _damage;
    public DecreaserHealth(float damage)
    {
        if (damage <= 0)
        {
            throw new InvalidOperationException();
        }
        _damage = damage;
    }
    public float ReturnHealth(float health)
    {
       
        float difference = health - _damage;
        if (difference.IsNegative())
        {
            return 0;
        }
        return health -= _damage;
    }
}
