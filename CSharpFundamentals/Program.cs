using System;

var firstName = "Ram";
Console.WriteLine($"Hello, {firstName}");

// Class work 1


//class work 2
Console.Write("Enter length in meter: ");
var length = Console.ReadLine();
var lengthNumber = double.Parse(length);
var feets = lengthNumber * 3.2808;
Console.WriteLine($"{lengthNumber} metres = {feets} feet");
