using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(GetterBulletMovement))]
public class BulletInitializer : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private GetterBulletMovement _getterBulletMovement;
    [SerializeField] private GetterDamage _getterDamage;
    private void Awake()
    {
        _bullet.Initialize(_getterBulletMovement.GetMove(), _getterDamage.GetReturnerHealth());
    }
}
