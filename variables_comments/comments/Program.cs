// string firstName = "Bob";
// int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets. ");
// Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets. ");

// To apply a block of comment
/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

// the below code are considered low-quality comments because they merely explain how c# or methods of the .net class library work.
/****
Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
****/


// the following comment makes the code less cluttered
/*
    The following code creates five random OrderIDs
    to test the fraud detection process. OrderIDs
    consist of a letter from A to E, and a three
    digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}