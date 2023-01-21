using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(GetterBulletMovement))]
public class BulletInitializer : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private GetterRotation _getterRotation;
    [SerializeField] private GetterBulletMovement _getterBulletMovement;
    private void Awake()
    {
        _bullet.Initialize(_getterBulletMovement.GetMove());
    }
}
