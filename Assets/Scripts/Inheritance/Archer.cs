using UnityEngine;

public class Archer : Warrior
{
    private float _criticalChance;

    public override int Damage
    {
        get
        {
            float rand = Random.Range(0f, 1f);
            if (rand <= _criticalChance)
                return base.Damage * 2;
            else
                return base.Damage;
        }
    }

    public Archer(int health, int damage, float criticalChance) : base(health, damage, DamageType.Range)
    {
        _criticalChance = criticalChance;
    }
}