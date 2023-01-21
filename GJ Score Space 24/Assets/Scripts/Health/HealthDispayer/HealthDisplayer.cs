using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(IHavingHealth))]
public class HealthDisplayer : MonoBehaviour
{
    private IHavingHealth _havingHealth;
    [SerializeField] private Image _healthBar;
    private void Awake()
    {
        _havingHealth = GetComponent<IHavingHealth>();
    }
    private void Start()
    {
        _havingHealth.Health.OnChangeHealth += DisplayHealth;
    }
    private void DisplayHealth()
    {
        _healthBar.DivideImageBar(_havingHealth.Health.MaxHealth,_havingHealth.Health.CurrentHealth);
    }
    private void OnDisable()
    {
        _havingHealth.Health.OnChangeHealth -= DisplayHealth;
    }
}
