using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerStraightVector : IReturnerVector
{
    public float Speed { get; set; }

    public ReturnerStraightVector(float speed)
    {
        Speed = speed;
    }

    public Vector3 ReturnVector() => Vector2.right * Speed;
}
