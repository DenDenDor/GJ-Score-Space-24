using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Mutation : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerInitializer _playerInitializer;
    [SerializeField] private GetterPlayerShooting _getterPlayerShooting;
    [SerializeField] private GetterMove _getterMove;
    private List<IChangerCharacteristic> _changableCharacteristics = new List<IChangerCharacteristic>();
    private int _orderOfRandomCharacteristic;

    public List<IChangerCharacteristic> ChangableCharacteristics { get => _changableCharacteristics; private set => _changableCharacteristics = value; }

    public event Action OnInitialize;
    private void Awake()
    {
        _changableCharacteristics.Add(_getterPlayerShooting);
        _changableCharacteristics.Add(_getterMove);
        _changableCharacteristics.ForEach(e => Set(e, e.GetCurrentStat()));
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int count = _changableCharacteristics.Count;
            List<int> list = new List<int>();
            for (int i = 0; i < count; i++)
               list.Add(i);
            ChangeCharactic(ref list, Improve);
            ChangeCharactic(ref list, Worsen);
            _playerInitializer.Initialize(_player.Health);
            OnInitialize?.Invoke();
        }
    }
    private void Improve() => GetRandomCharacteristic().ImproveStat();
    private void Worsen() => GetRandomCharacteristic().WorsenStat();
    private void ChangeCharactic(ref List<int> list, Action action)
    {
        int randomElement = Random.Range(0, list.Count);
        _orderOfRandomCharacteristic = list.GetRandomElementOfList();
        action();
        list.Remove(list[randomElement]);
    }
    private IChangerCharacteristic GetRandomCharacteristic() => _changableCharacteristics[_orderOfRandomCharacteristic];
    private void Set(IChangerCharacteristic changableCharacteristic, Stat stat)
    {
        changableCharacteristic.StartStat = stat;
    }
}
