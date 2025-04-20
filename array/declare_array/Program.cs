// Declaring Arrays;
/*****
string[] fraudulentOrderIDs = new string[3];

// Assigning values to the array element
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// Accesing Arrays

// Reassigning values to the array element
fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

*****/

// Initiliaze an array
// it uses collection expression expression syntax, which was introducedd in C# 12.
string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

// an older syntax
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
fraudulentOrderIDs[0] = "F000";

Console.WriteLine(fraudulentOrderIDs[0]);
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// the length property of an array
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
