using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : IMove
{
    private readonly Rigidbody2D _rigidbody2D;
    private readonly IReturnerVector _returnerVector;
    public PlayerMovement(Rigidbody2D rigidbody2D, IReturnerVector returnerVector)
    {
        _rigidbody2D = rigidbody2D;
        _returnerVector = returnerVector;
    }

    public void Move() => _rigidbody2D.velocity = _returnerVector.ReturnVector();
}
