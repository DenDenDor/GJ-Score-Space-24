using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IReturnerVector 
{
    public float Speed { get; set; }
    public Vector3 ReturnVector();
}
