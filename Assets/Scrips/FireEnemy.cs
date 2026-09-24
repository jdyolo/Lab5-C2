using UnityEngine;

public class FireEnemy : Enemy
{
    protected override void Awake()
    {
        maxHealth = 120;

        base.Awake();

        Debug.Log("FireEnemy inicializado.");
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
}