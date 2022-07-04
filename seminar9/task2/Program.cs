// Задача 2: Задайте значения M и N. Напишите программу, 
// которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNumbersFromMToN(int startNumber, int endNumber)
{
    if (endNumber <= startNumber-1)
    {
        return;
    }
    PrintNumbersFromMToN(startNumber, endNumber - 1);
    System.Console.Write($"{endNumber} ");
}

int m = Prompt("enter a start number: > ");
int n = Prompt("enter a last number: > ");
PrintNumbersFromMToN(m,n);