using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : IMove
{
    private readonly float _speed;
    private readonly Rigidbody2D _rigidbody2D;
    public PlayerMovement(Rigidbody2D rigidbody2D, float speed)
    {
        _rigidbody2D = rigidbody2D;
        _speed = speed;
    }
}
