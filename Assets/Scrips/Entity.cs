using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] protected int maxHealth = 100;

    protected BaseStats stats;

    protected int currentHealth
    {
        get { return stats.GetCurrentHealth(); }
    }

    protected virtual void Awake()
    {
        stats = new BaseStats(maxHealth);

        Debug.Log(
            gameObject.name + " creado con " +
            stats.GetCurrentHealth() + " de vida."
        );
    }

    public virtual void TakeDamage(int damage)
    {
        stats.TakeDamage(damage);

        Debug.Log(gameObject.name + " recibió " + damage + " de daño.");
        Debug.Log("Vida restante: " + stats.GetCurrentHealth());
    }
}