using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{
    protected override (bool, IHavingHealth) IsTrigger(Collider2D collision)
    {
      (bool, IHavingHealth) tuple = (false,null);
      if (collision.TryGetComponent<Player>(out Player player))
      {
            tuple = (true, player);
      }
        return tuple;
    }
}
