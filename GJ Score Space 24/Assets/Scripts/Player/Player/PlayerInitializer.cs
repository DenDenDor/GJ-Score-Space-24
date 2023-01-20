using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Player))]
[RequireComponent(typeof(GetterHealth))]
[RequireComponent(typeof(GetterMove))]
public class PlayerInitializer : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GetterHealth _getterHealth;
    [SerializeField] private GetterMove _getterMove;
    private void Awake()
    {
        _player.Initialize( _getterMove.GetMove(), _getterHealth.GetHealth());
    }
}
