using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerControllableVector : IReturnerVector
{
    public float Speed { get; set; }
    public ReturnerControllableVector(float speed)
    {
        Speed = speed;
    }
    public Vector2 ReturnVector() => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Speed;
}
