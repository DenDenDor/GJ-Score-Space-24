using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Gun))]
[RequireComponent(typeof(GetterRotation))]
[RequireComponent(typeof(GetterShooting))]
public class GunInitializer : MonoBehaviour
{
    [SerializeField] private Gun _gun;
    [SerializeField] private GetterRotation _getterRotation;
    [SerializeField] private GetterShooting _getterShooting;
    private void Awake()
    {
        _gun.Initialize(_getterRotation.GetRotation(),_getterShooting.GetAttack());
    }
}
