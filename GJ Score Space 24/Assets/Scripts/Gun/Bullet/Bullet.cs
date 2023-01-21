using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    private IMove _move;
    private IReturnerHealth _returnerHealth;
    public void Initialize(IMove move, IReturnerHealth returnerHealth)
    {
        _move = move;
        _returnerHealth = returnerHealth;
    }
    private void Update()
    {
        _move?.Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        (bool, IHavingHealth) isTrigger = IsTrigger(collision);
        if (isTrigger.Item1)
        {
            IAttack attack = new AttackByTrigger(isTrigger.Item2,_returnerHealth);
            attack.Attack();
            Destroy(gameObject);
        }
    }
    protected abstract (bool,IHavingHealth) IsTrigger(Collider2D collision); 
}
