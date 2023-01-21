using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyInitializer : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private GetterHealth _getterHealth;
    [SerializeField] private GetterEnemyMove _getterMove;
    [SerializeField] private GetterEnemyRotation _getterRotation;

    private void Awake()
    {
        _enemy.Initialize(_getterMove.GetMove(), _getterRotation.GetRotation(), _getterHealth.GetHealth());
    }
}