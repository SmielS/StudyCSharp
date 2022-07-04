// Задача 1: Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

System.Console.Write("enter a number: ");
string number = Console.ReadLine();
string reverseNumber = "";
for (int i = number.Length - 1; i >= 0; i--)
{
    reverseNumber+=number[i];
}
if (number == reverseNumber) System.Console.WriteLine($"number {number} is a polyndrome");
else System.Console.WriteLine($"number {number} is not a polyndrome");
