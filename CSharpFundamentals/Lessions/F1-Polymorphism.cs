// Polymorphism
// Static - Method Overloading
// Dyanamic - Method overriding

using System;

public class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Engine started.");
    }

    public void Start(float voltage)
    {
        Console.WriteLine($"Engine started with prescribed voltage {voltage}");
    }
}

public class Car: Vehicle
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("It's a car.");
    }
}

class Test1
{
    void Do()
    {
        Car c1 = new();
        c1.Start();
        c1.Start(34.5f);
    }
}