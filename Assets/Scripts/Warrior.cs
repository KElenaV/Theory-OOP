public class Warrior
{
    protected int Health;
    protected int Damage;
    protected DamageType DmgType;

    public Warrior(int health, int damage, DamageType dmgType)
    {
        Health = health;
        Damage = damage;
        DmgType = dmgType;
    }

    public void TakeDamage(int damage) => 
        Health -= damage;

    public bool IsAlive() => 
        Health > 0;

    public int GetDamage() => 
        Damage;

    public string GetInfo() => 
        $"HP: {Health}\nDMG: {Damage}";
}