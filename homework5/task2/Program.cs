// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

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

int SummingNotEvenArrayPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i<arr.Length; i+=2)
    {
        sum+=arr[i];
    }
    return(sum);
}

int[] myArray = InitRandomArray(4,-10,10);
PrintArray(myArray);
System.Console.WriteLine($"sum of not even elements of array is {SummingNotEvenArrayPosition(myArray)}");