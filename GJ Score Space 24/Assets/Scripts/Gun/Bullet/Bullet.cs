using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
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
        if (collision.TryGetComponent<IHavingHealth>(out IHavingHealth havingHealth))
        {
            IAttack attack = new MiddleAttack(havingHealth,_returnerHealth);
            attack.Attack();
            Destroy(gameObject);
        }
    }
}
