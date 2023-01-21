using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(IHavingHealth))]
public class HealthDisplayer : MonoBehaviour
{
    [SerializeField] private GetterHealth _getterHealth;
    [SerializeField] private Image _healthBar;
    private void Start()
    {
        _getterHealth.Health.OnChangeHealth += DisplayHealth;
    }
    private void DisplayHealth()
    {
        _healthBar.DivideImageBar(_getterHealth.Health.MaxHealth,_getterHealth.Health.CurrentHealth);
    }
    private void OnDisable()
    {
        _getterHealth.Health.OnChangeHealth -= DisplayHealth;
    }
}
