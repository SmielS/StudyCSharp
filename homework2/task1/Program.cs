//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Write("enter a number:");
string numstring = Console.ReadLine();
int numint = int.Parse(numstring);

int secDig = numint %100 / 10 ;

System.Console.WriteLine("second digit = " + secDig);