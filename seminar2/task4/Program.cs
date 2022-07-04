//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

Console.Write("Введите 1 чило:");
string numstring = Console.ReadLine();
int numint = int.Parse(numstring);

if (numint % 7 == 0 && numint % 23 == 0) System.Console.WriteLine("da");
else System.Console.WriteLine("net");