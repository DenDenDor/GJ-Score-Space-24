using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementByTransform : IMove
{
    public IReturnerVector ReturnerVector { get; set; }
    private Transform _currentTransform;

    public MovementByTransform(Transform currentTransform, IReturnerVector returnerVector)
    {
        _currentTransform = currentTransform;
        ReturnerVector = returnerVector;
    }

    public void Move()
    {
        _currentTransform.Translate(ReturnerVector.ReturnVector() * Time.deltaTime);
    }
}
