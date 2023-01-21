using UnityEngine;

[RequireComponent(typeof(Enemy))]
[RequireComponent(typeof(IGetterAttack))]
public class EnemyInitializer : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private GetterEnemyHealth _getterHealth;
    [SerializeField] private GetterEnemyMove _getterMove;
    [SerializeField] private GetterEnemyRotation _getterRotation;
    private IGetterAttack _getterAttack;

    private void Awake()
    {
        _getterAttack = GetComponent<IGetterAttack>();
        _enemy.Initialize(_getterMove.GetMove(), _getterRotation.GetRotation(), _getterHealth.GetHealth(), _getterAttack.GetAttack());
    }
}