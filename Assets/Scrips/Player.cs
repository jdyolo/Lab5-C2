using UnityEngine;

public class Player : Entity
{
    private Weapon equippedWeapon;

    private int experience = 0;
    private int level = 1;
    private int experienceToLevelUp = 10;

    protected override void Awake()
    {
        base.Awake();

        equippedWeapon = new FireWeapon();

        Debug.Log("Player inicializado.");
        Debug.Log("Arma inicial: " + equippedWeapon.GetElement());
        Debug.Log("Daño del arma: " + equippedWeapon.GetDamage());
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

        Debug.Log("El Player recibió daño.");
    }

    public void AddExperience(int amount)
    {
        experience += amount;

        Debug.Log("XP obtenida: " + amount);
        Debug.Log("XP total: " + experience);

        if (experience >= experienceToLevelUp)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        level++;

        equippedWeapon = new IceWeapon();

        Debug.Log("¡PLAYER SUBIÓ AL NIVEL " + level + "!");
        Debug.Log("Nueva arma: " + equippedWeapon.GetElement());
        Debug.Log("Nuevo daño: " + equippedWeapon.GetDamage());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            AddExperience(10);
        }
    }
}