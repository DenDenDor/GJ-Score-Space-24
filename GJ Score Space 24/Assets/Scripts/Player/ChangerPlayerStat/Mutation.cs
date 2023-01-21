using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutation : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerInitializer _playerInitializer;
    [SerializeField] private GetterPlayerShooting _getterPlayerShooting;
    [SerializeField] private GetterMove _getterMove;
    private List<IChangableCharacteristic> _changableCharacteristics = new List<IChangableCharacteristic>(); 
    private void Awake()
    {
        _changableCharacteristics.Add(_getterPlayerShooting);
        _changableCharacteristics.Add(_getterMove);
        _changableCharacteristics.ForEach(e => Set(e,e.GetCurrentStat()));

        //_player.Initialize();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _changableCharacteristics[0].WorsenStat();
            _playerInitializer.Initialize(_player.Health);
        }
    }
    private void Set(IChangableCharacteristic changableCharacteristic, Stat stat)
    {
        changableCharacteristic.StartStat = stat;
    }
}
