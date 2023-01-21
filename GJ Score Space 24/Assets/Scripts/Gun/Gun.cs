using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private IRotation _rotation;
    private IAttack _attack;
    public void Initialize(IRotation rotation, IAttack attack)
    {
        _rotation = rotation;
        _attack = attack;
    }
    private void Update()
    {
        _rotation?.Rotate();
        _attack?.Attack();
    }
}
