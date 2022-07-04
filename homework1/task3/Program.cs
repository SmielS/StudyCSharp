// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Enter a number: ");
string numberString = Console.ReadLine();
int numberInt = int.Parse(numberString);

if (numberInt % 2 == 0)
    Console.WriteLine($"number {numberInt} is even");
else 
    Console.WriteLine($"number {numberInt} isnt even");