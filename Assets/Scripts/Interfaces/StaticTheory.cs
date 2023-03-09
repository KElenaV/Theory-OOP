using System;
using UnityEngine;

public class StaticTheory : MonoBehaviour
{
    Enemy _enemy1 = new Enemy();
    Enemy _enemy2 = new Enemy();
    
    private void Start()
    {
        Main.Save();
        print(_enemy1.GetLevel());
        print(_enemy2.GetLevel());
        print(Enemy.GetMaxHealth());
        Enemy.Level++;
        print(_enemy1.GetLevel());
        print(_enemy2.GetLevel());
        print(Enemy.GetMaxHealth());
    }
}

class Enemy
{
    public static int Level = 1;

    public int GetLevel()
    {
        return Level;
    }

    public static int GetMaxHealth()
    {
        return Level * 100;
    }
}
