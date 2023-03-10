using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerGunRotation : IReturnerRotation
{
    private Transform _currentTransform;
    private float _offset;
    public ReturnerGunRotation(Transform currentTransform, float offset)
    {
        _currentTransform = currentTransform;
        _offset = offset;
    }
    public Vector3 ReturnRotation()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - _currentTransform.position;
        float rotationZ = Mathf.Atan2(difference.y,difference.x) * Mathf.Rad2Deg;
        return new Vector3(0, 0, rotationZ + _offset);
    }
}
