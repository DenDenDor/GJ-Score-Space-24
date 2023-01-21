using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : IReturnerVector
{
    private float _speed;
    private Vector2 _velocity;
    private readonly Transform _currentTransform;
    private readonly Transform _playerTarget;
    public float Speed { get; set ; }
    public CameraMove(Transform currentTransform, Transform playerTarget, float speed)
    {
        _speed = speed;
        _playerTarget = playerTarget;
        _currentTransform = currentTransform;
    }
    private float GetPlayerPosiotion(float position, float playerPositon, float velocity) => Mathf.SmoothDamp(position, playerPositon, ref velocity, _speed);
    public Vector3 ReturnVector()
    {
        return new Vector3
        (GetPlayerPosiotion(_currentTransform.position.x, _playerTarget.position.x, _velocity.x),
         GetPlayerPosiotion(_currentTransform.position.y, _playerTarget.position.y, _velocity.y),
         _currentTransform.position.z);
    }

}
