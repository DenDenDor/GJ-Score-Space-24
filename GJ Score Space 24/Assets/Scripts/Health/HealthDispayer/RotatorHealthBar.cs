using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorHealthBar : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, -_target.rotation.z);
    }
}
