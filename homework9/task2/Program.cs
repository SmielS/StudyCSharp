// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N 
// с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumNatural(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    return m+= SumNatural(m + 1, n);
}

int m = Prompt("enter a start number: > ");
int n = Prompt("enter a last number: > ");
int result = SumNatural(m, n);
System.Console.WriteLine(result);