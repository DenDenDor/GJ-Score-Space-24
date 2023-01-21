using UnityEngine;

public class ReturnerEnemyRotation : IReturnerRotation
{
    private readonly float _offset;
    private readonly Transform _self;
    private readonly Transform _target;

    public ReturnerEnemyRotation(float offset, Transform self, Transform target)
    {
        _offset = offset;
        _self = self;
        _target = target;
    }

    public Vector3 ReturnRotation()
    {
        var vector = _target.position - _self.position;
        var direction = vector.normalized;
        
        var rotationZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        return Vector3.forward * (rotationZ + _offset);
    }
}