using UnityEngine;

public sealed class Boss : FireEnemy
{
    [SerializeField] private int phaseTwoSpeed = 8;
    private bool phaseTwo = false;

    protected override void Awake()
    {
        maxHealth = 200;

        base.Awake();

        Debug.Log("Boss inicializado.");
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

        if (!phaseTwo && currentHealth <= maxHealth / 2)
        {
            phaseTwo = true;

            Debug.Log("¡BOSS ENTRÓ EN FASE 2!");
            Debug.Log("Nueva velocidad del Boss: " + phaseTwoSpeed);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(25);
        }
    }
}