public class Archer : Warrior
{
    private float _criticalChance;
    
    public Archer(int health, int damage, float criticalChance) : base(health, damage, DamageType.Range)
    {
        _criticalChance = criticalChance;
    }
}