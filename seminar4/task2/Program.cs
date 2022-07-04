// Задача 1: Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int quantity(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number/10;
        i++;
    }
    return (i);
}

int number = Prompt("enter a number: ");
System.Console.WriteLine($"quantity of numbers {number} is {quantity(number)}");