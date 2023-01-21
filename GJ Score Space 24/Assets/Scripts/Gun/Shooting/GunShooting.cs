using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : IAttack
{
    private readonly Bullet _bullet;
    private readonly Transform _shootPoint;
    private Transform _rotationPoint;
    private readonly float _offset = 90;
    public GunShooting(Bullet bullet,Transform shootPoint, Transform rotationPoint)
    {
        _bullet = bullet;
        _shootPoint = shootPoint;
        _rotationPoint = rotationPoint;
    }
    public void Attack()
    {
       Object.Instantiate(_bullet, _shootPoint.position, Quaternion.Euler(0,0,_offset + _rotationPoint.eulerAngles.z));
    }
}
