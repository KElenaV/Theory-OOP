public class Knight : Warrior
{
    private int _armor; 
    
    public Knight(int health, int damage, DamageType dmgType, int armor) : base(health, damage, dmgType)
    {
        _armor = armor;
    }

    public override void TakeDamage(int damage)
    {
        damage -= _armor / 4;
        if (damage > 0)
            base.TakeDamage(damage);
        else
            Health--;
    }
}