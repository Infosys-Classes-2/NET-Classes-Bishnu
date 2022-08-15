using System;
using System.Collections.Generic;
using Members;

public class Collection
{
    //List
    void Test1()
    {
        List<byte> ageOfStudents = new List<byte>();
        ageOfStudents.Add(45);
        ageOfStudents.Add(45);
        ageOfStudents.Add(45);
        ageOfStudents.Add(45);
        ageOfStudents.Add(45);
        ageOfStudents.Remove(45);

        foreach(var age in ageOfStudents)
            Console.WriteLine(age);

        List<Person> people = new List<Person>();
        var s = new Person();
        people.Add(s);
    }
    //Stack
    void TestStack()
    {
        // LIFO
        Stack<string> plates = new Stack<string>();

        plates.Push("plate1");
        plates.Push("plate2");
        plates.Push("plate3");
        plates.Push("plate4");
        plates.Pop();
    }

    //Queue
    void TestQueue()
    {
        // FIFO
        Queue<string> patientLine = new Queue<string>();
        patientLine.Enqueue("Patient 1");
        patientLine.Enqueue("Patient 2");
        patientLine.Enqueue("Patient 3");
        patientLine.Dequeue();
    }

    //Dictionary
    void TestDictionary()
    {
        Dictionary<string, long> population = new()
        {
            ["Nepal"] = 243255223,
            ["India"] = 464243255223,
            ["China"] = 90243255223
        };

        population.Remove("china");
    }
}
