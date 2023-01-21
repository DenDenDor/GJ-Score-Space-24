using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementByChangingTransform : IMove
{
    private Transform _currentTranform;
    public IReturnerVector ReturnerVector { get; set; }
    public MovementByChangingTransform(Transform currentTransform, IReturnerVector returnerVector)
    {
        _currentTranform = currentTransform;
        ReturnerVector = returnerVector;
    }

    public void Move()
    {
        Debug.Log("COOL!");
        _currentTranform.position = ReturnerVector.ReturnVector();
    }
}
