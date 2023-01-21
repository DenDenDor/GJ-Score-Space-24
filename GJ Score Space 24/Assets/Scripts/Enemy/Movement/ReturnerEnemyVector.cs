using UnityEngine;

public class ReturnerEnemyVector : IReturnerVector
{
    public float Speed { get; set; }

    private readonly Transform _self;
    private readonly Transform _target;

    private readonly float _attackDistance;
    private readonly float _runOutDistance;

    public ReturnerEnemyVector(float speed, float attackDistance, float runOutDistance, Transform self, Transform target)
    {
        Speed = speed;

        _self = self;
        _target = target;

        _attackDistance = attackDistance;
        _runOutDistance = runOutDistance;
    }
    
    public Vector3 ReturnVector()
    {
        var vector = _target.position - _self.position;
        var direction = vector.normalized;

        var distance = vector.magnitude;

        if (distance > _attackDistance)
            return direction * Speed;

        if (distance <= _runOutDistance)
            return -direction * Speed;

        return Vector2.zero;
    }
}