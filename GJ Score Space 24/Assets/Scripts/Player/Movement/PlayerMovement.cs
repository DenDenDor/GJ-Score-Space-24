using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : IMove
{
    private readonly Rigidbody2D _rigidbody2D;
    public IReturnerVector ReturnerVector { get; set; }
    public PlayerMovement(Rigidbody2D rigidbody2D, IReturnerVector returnerVector)
    {
        _rigidbody2D = rigidbody2D;
        ReturnerVector = returnerVector;
    }


    public void Move() => _rigidbody2D.velocity = ReturnerVector.ReturnVector();
}
