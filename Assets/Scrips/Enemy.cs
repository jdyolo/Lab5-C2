using UnityEngine;

public class Enemy : Entity
{
    protected override void Awake()
    {
        base.Awake();

        Debug.Log("Enemy inicializado.");
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

        if (currentHealth <= 0)
        {
            Debug.Log("Enemy derrotado.");
            Destroy(gameObject);
        }
    }
}