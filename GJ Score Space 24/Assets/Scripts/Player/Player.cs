using UnityEngine;

public class Player : MonoBehaviour, IHavingHealth
{
    private IMove _move;
    private IAttack _attack;
    public IHealth Health { get; set; }
    public IMove Move { get => _move; private set => _move = value; }
    public IAttack Attack { get => _attack; private set => _attack = value; }
    public void Initialize(IMove move, IHealth health, IAttack attack)
    {
        _move = move;
        Health = health;
        _attack = attack;
    }
    private void Update()
    {
        _attack?.Attack();
    }
    private void FixedUpdate()
    {
        _move?.Move();
    }
}