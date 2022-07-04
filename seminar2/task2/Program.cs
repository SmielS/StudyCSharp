// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

int number = new Random().Next(10, 99);
System.Console.WriteLine(number);

int number1 = number / 10;
int number2 = number % 10;

if (number1 > number2) System.Console.WriteLine(number1);
else System.Console.WriteLine(number2);