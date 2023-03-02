using System;
using UnityEngine;

public class Theory : MonoBehaviour
{
    IMovable player = new Player();
    IMovable vehicle = new Vehicle();

    private void Start()
    {
        player.Move();
        vehicle.Move();
    }
}

public interface IMovable
{
    float Speed { get; }

    void Move();
}

public interface IDamagable
{
    void TakeDamage(int damage);
}

public class Player : IMovable, IDamagable
{
    private int _health = 100;
    public float Speed { get; set; }
    
    public void Move()
    {
        Debug.Log("Игрок управляется клавишами");
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }

    public void DoSomething()
    {
        Debug.Log("Do something");
    }
}

public class Vehicle : IMovable
{
    public float Speed { get; } = 20f;
    
    public void Move()
    {
        Debug.Log($"Машина едет со скоростью {Speed}");
    }
}
