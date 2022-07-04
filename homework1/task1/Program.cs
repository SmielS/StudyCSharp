// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.Write("Enter first number: ");
string firstNumberString = Console.ReadLine();
int firstNumberInt = int.Parse(firstNumberString);
Console.Write("Enter second number: ");
string secondNumberString = Console.ReadLine();
int secondNumberInt = int.Parse(secondNumberString);

if (firstNumberInt > secondNumberInt)
    Console.WriteLine($"This number: ({firstNumberInt}) more then this number: ({secondNumberInt})");
else    
     Console.WriteLine($"This number: ({secondNumberInt}) more then this number: ({firstNumberInt})");