using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterHealth : GetterStat<HealthStat>
{
    [SerializeField] private HealthStat _playerStat;
    protected override HealthStat PlayerStat { get => _playerStat; set => _playerStat = value; }
    public Health GetHealth() => new Health(_playerStat.Health);
}
