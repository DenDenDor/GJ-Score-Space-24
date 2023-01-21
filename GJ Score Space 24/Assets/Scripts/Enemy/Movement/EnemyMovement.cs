using UnityEngine;

public class EnemyMovement : IMove
{
    public IReturnerVector ReturnerVector { get; set; }

    private readonly Rigidbody2D _rigidbody2D;

    private Vector2 _targetVelocity;

    public EnemyMovement(Rigidbody2D rigidbody2D, IReturnerVector returnerVector)
    {
        _rigidbody2D = rigidbody2D;
        ReturnerVector = returnerVector;
    }

    public void Move()
    {
        _targetVelocity = ReturnerVector.ReturnVector();

        _rigidbody2D.velocity = Vector2.MoveTowards(_rigidbody2D.velocity, _targetVelocity, Time.fixedDeltaTime * 10f);
    }
}