using UnityEngine;

public class EnemyGunInitializer : MonoBehaviour, IGetterAttack
{
    [SerializeField] private GetterEnemyRotation _getterRotation;
    [SerializeField] private GetterEnemyShooting _getterShooting;
    public IAttack GetAttack() => new Gun(_getterRotation.GetRotation(), _getterShooting.GetAttack());
}
