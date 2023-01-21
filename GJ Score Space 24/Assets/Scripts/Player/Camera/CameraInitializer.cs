using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInitializer : MonoBehaviour
{
    [SerializeField] private MovableCamera _movableCamera;
    [SerializeField] private GetterCameraStat _getterCameraStat;
    private void Awake()
    {
        _movableCamera.Initialize(_getterCameraStat.GetMove());
    }
}
