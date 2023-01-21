using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableCamera : MonoBehaviour
{
    private IMove _move;
    public void Initialize(IMove move)
    {
        _move = move;
    }
    private void FixedUpdate()
    {
        _move?.Move();
    }
}
