using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(GetterRotation))]
[RequireComponent(typeof(GetterPlayerShooting))]
public class GunInitializer : MonoBehaviour, IGetterAttack
{
    [SerializeField] private GetterRotation _getterRotation;
    [SerializeField] private GetterPlayerShooting _getterShooting;
    public IAttack GetAttack() => new Gun(_getterRotation.GetRotation(), _getterShooting.GetAttack());

}
