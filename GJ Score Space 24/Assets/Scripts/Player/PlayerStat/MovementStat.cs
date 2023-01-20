using System.Collections;
using System;
using UnityEngine;
[Serializable]
public class MovementStat : PlayerStat
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    public Rigidbody2D Rigidbody2D { get => _rigidbody2D; private set => _rigidbody2D = value; }
    public float Speed { get => _speed; private set => _speed = value; }
}
[Serializable]
public class HealthStat : PlayerStat
{
    [SerializeField] private float _health;

    public float Health { get => _health; private set => _health = value; }
}
public abstract class PlayerStat
{

}

