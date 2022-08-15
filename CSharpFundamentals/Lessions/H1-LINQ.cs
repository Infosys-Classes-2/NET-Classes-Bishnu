// Language INtegrated Query (LINQ)

using System;
using System.Collections.Generic;
using System.Linq;

public class LINQ
{
    int[] numbers = { 3, 4, 6, 12, 34, 23, 36, 32, 43, 89 };
    List<string> names = new List<string> { "Ram", "Shyam", "Dhiraj", "Jenny", "Milan", "Tak" };

    public void LearnLINQ()
    {
        // 1. Fetch all even numbers on "numbers"
        // Method syntax
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        // Expression syntax
        evenNumbers = from n in numbers
                      where n % 2 == 0
                      select n;

        // 2. Fetch all odd numbers
        var oddNumbers = numbers.Where(number => number % 2 != 0);

        // 3. Fetch all perfect squares from "numbers"
        var perfectSquares = numbers.Where(x => IsPerfectSquare(x));

        // 4. Convert all numbers in "numbers" to their cubes
        var cubes = numbers.Select(x => x * x * x);

        // 5. Get squares of all even numbers in "numbers"
        var squareEvenNumbers = numbers.Where(x => (x & 1) == 0).Select(y => y * y);

        // 6. Get next five items skipping first two
        var firstFive = numbers.Skip(2).Take(5);

        // 7. Quatifiers
        var checkIfAllEven = numbers.All(x => (x & 1) == 0);
        var checkIfAnyEven = numbers.Any(x => (x & 1) == 0);

        // 8. Get all names starting with letter 'a'
        var namesStartingA = names.Where(x => x.ToUpper().StartsWith('A'));

        // 9. Get all names on "names" with lenght greater that 5 characters
        var namesWithLength = names.Where(x => x.Length > 5);
    }

    private bool IsPerfectSquare(int n)
    {
        var sr = Math.Sqrt(n);
        var product = sr * sr;
        return product == n;
    }
}