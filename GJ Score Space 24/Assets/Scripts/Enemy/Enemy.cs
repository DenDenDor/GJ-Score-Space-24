using UnityEngine;

public class Enemy : MonoBehaviour, IHavingHealth
{
    private IMove _move;
    private IRotation _rotation;
    private IAttack _attack;
    public IHealth Health { get; set; }
    public void Initialize(IMove move, IRotation rotation, IHealth health, IAttack attack)
    {
        _move = move;
        _rotation = rotation;
        Health = health;
        _attack = attack;
    }
    private void Update()
    {
        _rotation?.Rotate();
        _attack?.Attack();
    }
    private void FixedUpdate()
    {
        _move?.Move();
    }
}