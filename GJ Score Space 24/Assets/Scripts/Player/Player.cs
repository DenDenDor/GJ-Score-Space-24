using UnityEngine;

public class Player : MonoBehaviour, IHavingHealth
{
    private IMove _move;
    public IHealth Health { get; set; }
    private IAttack _attack;
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