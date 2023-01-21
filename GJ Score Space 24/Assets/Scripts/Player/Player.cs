using UnityEngine;

public class Player : MonoBehaviour, IHavingHealth
{
    private IMove _move;
    private IRotation _rotation;
    public Health Health { get; set; }

    public void Initialize(IMove move, IRotation rotation, Health health)
    {
        _move = move;
        _rotation = rotation;
        Health = health;
    }
    
    private void FixedUpdate()
    {
        _move?.Move();
        _rotation?.Rotate();
    }
}