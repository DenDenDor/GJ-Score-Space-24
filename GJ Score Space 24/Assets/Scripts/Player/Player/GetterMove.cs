using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterMove : GetterStat<MovementStat>
{
    [SerializeField] private MovementStat _playerStat;
    protected override MovementStat PlayerStat { get => _playerStat; set => _playerStat = value; }
    public IMove GetMove() => new PlayerMovement(_playerStat.Rigidbody2D, _playerStat.Speed);
}
