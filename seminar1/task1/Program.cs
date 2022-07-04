// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
Console.Write("Введите первое чило:");
string num1string = Console.ReadLine();
int num1int = int.Parse(num1string);
Console.WriteLine("you entered 1st number: " + num1int);

Console.Write("Введите второе чило:");
string num2string = Console.ReadLine();
int num2int = int.Parse(num2string);
Console.WriteLine("you entered 2nd number: " + num2int);

if (num2int * num2int == num1int)

    Console.WriteLine("Первое число = квадрат второго числа");

else

    Console.WriteLine("Первое число - не квадрат второго числа"); фыв
