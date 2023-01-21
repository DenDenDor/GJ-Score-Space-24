using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingByApproach : IAttack
{
    private readonly IAttack _attack;
    private readonly Transform _currentTransform;
    private readonly Transform _target;
    private readonly float _range;
    public AttackingByApproach(Transform currentTrasform, Transform target, float range, IAttack attack)
    {
        _range = range;
        _currentTransform = currentTrasform;
        _target = target;
        _attack = attack;

    }

    public void Attack()
    {
        if (Vector2.Distance(_currentTransform.position, _target.position) <= _range)
        {
            _attack?.Attack();
        }
    }
}
