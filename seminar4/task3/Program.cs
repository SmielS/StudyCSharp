// Задача 2: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}


int number = Prompt("enter a number: ");
int result = 1;

while (number > 0)
{
    result *= number;
    number--;
}
System.Console.WriteLine(result);