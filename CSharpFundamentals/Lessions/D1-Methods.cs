using System;

public class MethodLearning
{
    // returns nothing, take no arguments
    public void PrintNepal()
    {
        Console.WriteLine("Nepal");
    }
    // returns nothing, take some arguments
    public void PrintNepalNTimes(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nepal");
        }
    }

    // returns some value, take no/some arguments
    public int Add(int x, int y)
    {
        var sum = x + y;
        return sum;
    }

    // input- Bishnu Singh sdfasfd Rawal, output - BR
    public string GetInitials(string fullName)
    {
        var nameParts = fullName.Split(" ");
        var len = nameParts.Length;
        var first = nameParts[0][0];
        var last = nameParts[len - 1][0];

        var initial = $"{first}{last}";
        return initial;
    }

    // returns multiple values, take no/some arguments

    // variable number of arguments, named parameters, optional parameters 

}