using System;

namespace Members;
public class Person
{
    public double age; // Instance member
    public string Name { get; set; }
    public static byte noOfEyes; //static member

    public void PrintDetails()
    {        
    }
}

public class Test
{
    public void Do()
    {
        Person p1 = new();
        p1.age = 45; 

        Person.noOfEyes = 2;   

        Math.Cos(3435); 
    }
}