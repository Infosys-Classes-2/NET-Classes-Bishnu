// Parallel Programming: TPL (Task Parallel Library)
// Asynchronous Programming: async, await

// 1000 images - Rotate 180 degrees

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

public class LearnParallel
{
    int[] numbers = { 12, 23, 30, 46, 10, 37, 3453, 43535, 4644,4565575, 5757, 3453 };
    public void Do()
    {
        //Sequential version
        Console.WriteLine("Sequential loop:");
        foreach (var num in numbers)
        {
            GetFactorial(num);
            Console.WriteLine($"Working for {num}");
        }

        // Parallel version
        Console.WriteLine("Parallel Loop:");
        Parallel.ForEach(numbers, num =>
        {
            GetFactorial(num);
            Console.WriteLine($"Working for {num}");
        });
    }

    private void GetFactorial(long n)
    {
        Thread.Sleep(1000);
        // if (n == 0 || n == 1)
        //     return 1;
        // return n * GetFactorial(n - 1);
    }
}


