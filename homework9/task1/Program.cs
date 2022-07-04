// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N
// с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNumbersFromMToN(int startNumber, int endNumber)
{
    if (endNumber < startNumber)
    {
        return;
    }
    if (startNumber % 2 != 0) startNumber++;
    if (endNumber % 2 != 0) endNumber--;
    PrintNumbersFromMToN(startNumber, endNumber - 2);
    System.Console.Write($"{endNumber} ");
}

int m = Prompt("enter a start number: > ");
int n = Prompt("enter a last number: > ");
PrintNumbersFromMToN(m, n);