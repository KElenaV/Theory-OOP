using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    private float _seconds;

    public float Hours
    {
        get { return _seconds / 3600; }
        set
        {
            if(value < 0 || value > 24)
                print("Можно задать диапазон от 0 до 24");
            else
                _seconds = value * 3600;
        }
    }

    private void Start()
    {
        Hours = 2.5f;
        print($"Hours: {Hours} / Seconds: {_seconds}");
        Hours = 30;
        print($"Hours: {Hours} / Seconds: {_seconds}");
    }
}
