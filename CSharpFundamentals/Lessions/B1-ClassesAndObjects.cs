// Animal 
using System;

namespace AboutClasses;
internal class Animal1
{
    // Members: fields, methods
    // Access modifiers: public, private, internal, protected
    internal float weight;
    internal string type;

    void Eat()
    {        
        Console.WriteLine(type + " is eating.");
    }

    internal void PrintDetails()
    {
        Eat();
        Console.WriteLine($"Weight of {type} is {weight} kg.");
    }
}
