//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.Write("Enter first number: ");
string firstNumberString = Console.ReadLine();
int firstNumberInt = int.Parse(firstNumberString);
Console.Write("Enter second number: ");
string secondNumberString = Console.ReadLine();
int secondNumberInt = int.Parse(secondNumberString);
Console.Write("Enter third number: ");
string thirdNumberString = Console.ReadLine();
int thirdNumberInt = int.Parse(thirdNumberString);
int max = 0;

if (firstNumberInt > secondNumberInt && firstNumberInt > thirdNumberInt)
    max = firstNumberInt;
    
if (secondNumberInt > firstNumberInt && secondNumberInt > thirdNumberInt)
    max = secondNumberInt; 

if (thirdNumberInt > firstNumberInt && thirdNumberInt > secondNumberInt) 
    max = thirdNumberInt;

Console.WriteLine("Max number = " + max);
