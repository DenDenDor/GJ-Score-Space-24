using System.Collections;
using System;
using UnityEngine;

public class Health 
{
    private float _health;

    public float CurrentHealth { get => _health; private set => _health = value; }

    public event Action OnChangeHealth;
    public Health(float health)
    {
        _health = health;
    }
    public void ApplyDamage(IReturnerHealth returnerHealth)
    {
        _health = returnerHealth.ReturnHealth(_health);
        OnChangeHealth?.Invoke();
    }
}
