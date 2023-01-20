using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private IMove _move;
    private Health _health;
    public void Initialize(IMove move, Health health)
    {
        _move = move;
        _health = health;
    }
    private void FixedUpdate()
    {
        _move?.Move();
    }
}
