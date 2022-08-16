using System;
using System.IO;

public class FileIO
{
    public void Do()
    {
        string filePath = @"D:\Test\test1.txt";
        
        Directory.CreateDirectory(@"D:\Test\Test1");

        File.AppendAllText(filePath, "This is yet another line..");
        Console.WriteLine("File created successfully");

        FileInfo fi = new(filePath);
        var text = File.ReadAllText(filePath);
        Console.Write("File Details:");
        Console.WriteLine("Created Date: " + fi.CreationTime);
        Console.WriteLine("Last update Date: " + fi.LastWriteTime);
        Console.WriteLine($"Size: {(float)fi.Length / 1024} KB");
        
    }
}