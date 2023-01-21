using UnityEngine;

[RequireComponent(typeof(Player))]
[RequireComponent(typeof(GetterHealth))]
[RequireComponent(typeof(GetterMove))]
[RequireComponent(typeof(GetterRotation))]
[RequireComponent(typeof(IGetterAttack))]
public class PlayerInitializer : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GetterHealth _getterHealth;
    [SerializeField] private GetterMove _getterMove;
    private IGetterAttack _getterAttack;
    private void Awake()
    {
        _getterAttack = GetComponent<IGetterAttack>();
        _player.Initialize(_getterMove.GetMove(), _getterHealth.GetHealth(), _getterAttack.GetAttack());
    }
}