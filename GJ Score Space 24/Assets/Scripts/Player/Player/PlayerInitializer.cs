using UnityEngine;

[RequireComponent(typeof(Player))]
[RequireComponent(typeof(GetterHealth))]
[RequireComponent(typeof(GetterMove))]
[RequireComponent(typeof(GetterRotation))]
public class PlayerInitializer : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GetterHealth _getterHealth;
    [SerializeField] private GetterMove _getterMove;
    [SerializeField] private GetterRotation _getterRotation;

    private void Awake()
    {
        _player.Initialize(_getterMove.GetMove(), _getterRotation.GetRotation(), _getterHealth.GetHealth());
    }
}