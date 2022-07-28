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



// Datatypes: Numbers, Strings, booleans, characters, derived types

// Numbers: Integer (e.g. 34, 56), Floating point (23.56, 111.0111)
byte a = 255;// 1 byte = 8 bit = 11111111 = 255
short b = 32767; // 2 byte 
int c = int.MinValue; //4 byte
long d = long.MaxValue;

float e = 334.454543535232424242443424f;
double f = 23422.3453534523453252345525;
decimal g = 234243242.2432342312341434252424242m;

char h = 'r';
string i = "sdafasf fa";
bool j = true;

// Declaring and initializing variables
byte age = 45; //Explicit
var age1 = 45; //Implicit type

// nullable varialbes
float? radius = 56.78f;
radius = null;

// Array
// One dimensional
byte[] scores = new byte[1000];
scores[0] = 45;
scores[1] = 15;
scores[2] = 75;
scores[3] = 42;
scores[4] = 45;
scores[5] = 40;

var x = scores[49];

char[] scores1 = { 'a', '5', '7' };

// Multi dimensional
double[,] matrix = new double[2, 3];
matrix[0, 0] = 34.5;
matrix[1, 2] = 67.1;

double[,] table = { { 2, 3 }, { 5, 6 } };

// Jagged array
short[][] data = new short[4][];

short[] dp1 = { 2, 3, 4, 5, 6 };
data[0] = dp1;

//3,4,5
//1,2
//3,4,5,6,7,8,9
