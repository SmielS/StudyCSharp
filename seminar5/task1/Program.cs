// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] InitArray(int len, int min, int max)
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

int CalcSumElements(int[] arr, int sign = 1)
{
    int sum = 0;
    foreach (int element in arr)
    {
        if (element*sign > 0)
        {
            sum += element;
        }
    }
    return (sum);
}

int[] myArray = InitArray(12, -9, 9);
PrintArray(myArray);
int sumPositive = CalcSumElements(myArray);
System.Console.WriteLine($"sum of positives elements is {sumPositive}");
int sumNegative = CalcSumElements(myArray, -1);
System.Console.WriteLine($"sum of negatives elements is {sumNegative}");
