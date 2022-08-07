using System;

public class Triangle: IShape
{
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    
    private double a;
    private double b;
    private double c;

    public double GetPerimeter() => a + b + c;

    public double GetArea()
    {
        var s = GetPerimeter() / 2;
        var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return area;
    }
}
