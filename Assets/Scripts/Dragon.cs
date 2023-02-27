public class Dragon : Warrior
{
    public Dragon(int health, int damage, DamageType dmgType) : base(health, damage, dmgType)
    {
    }

    public void Heal(int health) => 
        Health += health;
}