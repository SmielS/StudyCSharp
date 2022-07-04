// Задача 1: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] InitRandomArray(int len, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    foreach (int element in arr)
    {
        System.Console.Write($"{element}; ");
    }
    System.Console.WriteLine();
}

int CountingEvenNumbers(int[] arr)
{
    int count = 0;
    foreach (int element in arr)
    {
        if (element %2 == 0) count++;
    }
    return (count);
}

int[] myArray = InitRandomArray(4, 100, 999);
PrintArray(myArray);

System.Console.WriteLine($"array have {CountingEvenNumbers(myArray)} even numbers");