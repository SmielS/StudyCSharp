// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int number = Prompt("enter a number: ");
int degree = Prompt("enter a degree of entered number: ");
int result = 1;
int count = degree;

while (count > 0)
{
    result *= number;
    count--;
}
System.Console.WriteLine($"{number}^{degree} = {result}");