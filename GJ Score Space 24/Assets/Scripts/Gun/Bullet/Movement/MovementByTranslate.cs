using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementByTranslate : IMove
{
    public IReturnerVector ReturnerVector { get; set; }
    private Transform _currentTransform;

    public MovementByTranslate(Transform currentTransform, IReturnerVector returnerVector)
    {
        _currentTransform = currentTransform;
        ReturnerVector = returnerVector;
    }

    public void Move()
    {
        _currentTransform.Translate(ReturnerVector.ReturnVector() * Time.deltaTime);
    }
}
