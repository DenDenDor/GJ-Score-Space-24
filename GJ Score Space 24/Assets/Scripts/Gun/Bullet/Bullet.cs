using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private IMove _move;
    public void Initialize(IMove move)
    {
        Debug.Log("INIT!");
        _move = move;
    }
    private void Update()
    {
        _move?.Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
