public class Warrior
{
    protected int Health;
    protected DamageType DmgType;
    
    public virtual int Damage { get; protected set; }
    public bool isAlive => Health > 0;

    public Warrior(int health, int damage, DamageType dmgType)
    {
        Health = health;
        Damage = damage;
        DmgType = dmgType;
    }

    public virtual void TakeDamage(int damage) => 
        Health -= damage;

    public string GetInfo() => 
        $"HP: {Health}\nDMG: {Damage}";
}