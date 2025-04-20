// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, C#");

// Calling different kinds of methods in the .net class library

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;



// Console.WriteLine(firstValue + secondValue);
// Console.WriteLine(largerValue);


Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

dice.Next();

/*
Random dice = new Random(9);
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
*/
