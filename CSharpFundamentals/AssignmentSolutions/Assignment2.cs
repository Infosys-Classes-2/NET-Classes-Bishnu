
using System;

public class Assignment2
{
    // Print prime numbers less than 500
    public void GetPrimes()
    {
        for (int i = 1; i <= 500; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    private bool IsPrime(int x)
    {
        for (int d = 2; d * d <= x; d++)
        {
            if (x % d == 0)
                return false;
        }
        return true;
    }

    // Print pattens
    public void PrintPattern()
    {
        int rows = 10;
        for (int i = 1; i <= rows; i++)
        {
            for(int j = rows -1; j >= i; j--)
            {                
                Console.Write(" ");
            }

            for(int j = 1; j <= 2 * i - 1; j++)
            {                
                Console.Write("*");
            }
            Console.WriteLine();            
        }
    }
}