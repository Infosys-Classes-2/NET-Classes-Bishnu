using System;

class TestClasses
{
    public static void Main()
    {
        // Animal cow = new();
        // Animal goat = new();
        // Animal buffalo = new();
        // Animal deer = new();
        // var fish = new Animal();

        // cow.weight = 345.6f;
        // cow.type = "Cow";
        // cow.PrintDetails();

        // BranchesAndLoops br = new();
        // br.LearnLooping();

        // Assignment2 assignment2 = new();
        // assignment2.PrintPattern();

        MethodLearning ml = new();
        ml.PrintNepal();
        ml.PrintNepalNTimes(10);
        var x = ml.GetInitials("Milan sfafsdf Dhakal");
        Console.WriteLine(x);
    }
}
