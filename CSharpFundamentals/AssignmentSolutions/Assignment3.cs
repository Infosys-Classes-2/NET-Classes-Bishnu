using System;
using System.Linq;

public class Assignment3
{
    // Product of digits
    internal int GetProductAscii(int n)
    {
        string number = n.ToString();
        int product = 1;
        for (int i = 0; i < number.Length; i++)
        {
            product = product * (number[i] - 48);
        }
        return product;
    }
    internal int GetProductDivision(int n)
    {
        int k, mul = 1;
        while (n != 0)
        {
            k = n % 10;
            n = n / 10;
            mul = mul * k;
        }
        return mul;
    }

    // Nth Fib
    internal long GetNthFib(int n)
    {
        //base case
        if (n <= 2)
            return n - 1;

        return GetNthFib(n - 1) + GetNthFib(n - 2);
    }

    internal long GetNthFibIterative(int n)
    {
        long[] series = new long[n];
        series[0] = 0;
        series[1] = 1;

        for (int i = 2; i < n; i++)
        {
            series[i] = series[i - 1] + series[i - 2];
        }

        return series[n - 1];
    }

    // interger to binary
    internal string GetBinary(int n)
    {
        int k;
        string binaryString = string.Empty;

        while (n != 0)
        {
            k = n % 2;
            binaryString += k.ToString();
            n = n / 2;
        }
        
        var len = binaryString.Length;
        char[] bString = new char[len];
        for (int i = 0; i < len; i++)
        {
            bString[i] = binaryString[len - 1];
        }        

        return bString.ToString();
    }
}

// 234 => 24
// 0 1 1 2 3 5 8 13 21 ... 5th Fib num = 3
// 