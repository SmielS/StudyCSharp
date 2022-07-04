// Задача 1: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int sum(int maxNumber)
{
    int result = 0;
    for (int i = 1; i <= maxNumber; i++)
    {
        result += i;
    }
    return result;
}

int sumGauss(int maxNumber)
{
    return maxNumber * (maxNumber + 1) / 2;
}

int number = Prompt("enter a number: ");
System.Console.WriteLine($"sum from 1 to {number} is {sum(number)}");
System.Console.WriteLine($"gauss sum = {sumGauss(number)}");