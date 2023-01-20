using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Gun))]
[RequireComponent(typeof(GetterRotation))]
public class GunInitializer : MonoBehaviour
{
    [SerializeField] private Gun _gun;
    [SerializeField] private GetterRotation _getterRotation;
    private void Awake()
    {
        _gun.Initialize(_getterRotation.GetRotation());
    }
}
