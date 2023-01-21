using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(IHavingHealth))]
public class HealthDisplayer : MonoBehaviour
{
    private IHavingHealth _havingHealth;
    private void Awake()
    {
        _havingHealth = GetComponent<IHavingHealth>();
    }
    private void Start()
    {
       // _havingHealth.Health?
    }
}
