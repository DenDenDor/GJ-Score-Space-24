using UnityEngine;

public class Enemy : MonoBehaviour
{
    private IMove _move;
    private IRotation _rotation;
    private Health _health;

    public void Initialize(IMove move, IRotation rotation, Health health)
    {
        _move = move;
        _rotation = rotation;
        _health = health;
    }

    private void FixedUpdate()
    {
        _move?.Move();
        _rotation?.Rotate();
    }
}