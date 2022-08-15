// Type parameter

using System;

public class Generic 
{
    // Print() is generic method
    public void Print<T>(T x)
    {
        Console.WriteLine(x);
    }
}

class Test4
{
    void Test()
    {
        Generic g = new();
        g.Print<string>("Hey there!! How are you?");
        g.Print<string>("Hey there!! How are you?");
        g.Print<float>(4753.45f);
        g.Print<bool>(true);

    }
}