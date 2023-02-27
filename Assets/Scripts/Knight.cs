public class Knight : Warrior
{
    private int _armor; 
    
    public Knight(int health, int damage, DamageType dmgType, int armor) : base(health, damage, dmgType)
    {
        _armor = armor;
    }
}