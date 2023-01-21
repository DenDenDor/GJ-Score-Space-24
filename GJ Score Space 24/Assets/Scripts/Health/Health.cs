using System.Collections;
using System;
using UnityEngine;

public class Health : IHealth
{
    private float _currentHealth;

    public float CurrentHealth { get => _currentHealth; private set => _currentHealth = value; }
    public float MaxHealth { get; private set; }
    public event Action OnChangeHealth;
    public Health(float health)
    {
        MaxHealth = health;
        _currentHealth = health;
    }
    public void ApplyDamage(IReturnerHealth returnerHealth)
    {
        _currentHealth = returnerHealth.ReturnHealth(_currentHealth);
        OnChangeHealth?.Invoke();
    }
}
