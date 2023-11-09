using System;
using System.Collections.Generic;
using UnityEngine;

public class AbstractionTheory : MonoBehaviour
{
    List<Figure> figures = new List<Figure>()
    {
        new Rectangle(4,5),
        new Circle(4)
    };

    private void Start()
    {
        foreach (var figure in figures) 
            print(figure.GetInfo());
    }
}

abstract class Figure
{
    protected abstract float Perimeter();

    protected abstract float Area();

    public string GetInfo()
    {
        return $"{GetType()}: P = {Perimeter()}; S = {Area()}";
    }
}

class Rectangle : Figure
{
    private float _wight;
    private float _height;

    public Rectangle(float wight, float height)
    {
        _wight = wight;
        _height = height;
    }
    
    protected override float Perimeter()
    {
        return (_wight * _height) * 2;
    }

    protected override float Area()
    {
        return _wight * _height;
    }
}

class Circle : Figure
{
    private float _radius;

    public Circle(float radius)
    {
        _radius = radius;
    }

    protected override float Perimeter()
    {
        return 2 * Mathf.PI * _radius;
    }

    protected override float Area()
    {
        return Mathf.PI * _radius * _radius;
    }
}