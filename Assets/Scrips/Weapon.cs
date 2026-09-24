public class Weapon
{
    protected int damage;
    protected float attackRate;
    protected string element;

    public Weapon(int damage, float attackRate, string element)
    {
        this.damage = damage;
        this.attackRate = attackRate;
        this.element = element;
    }

    public int GetDamage()
    {
        return damage;
    }

    public float GetAttackRate()
    {
        return attackRate;
    }

    public string GetElement()
    {
        return element;
    }
}