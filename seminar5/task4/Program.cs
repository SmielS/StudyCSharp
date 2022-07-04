// Задача 3: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке 
// [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

void SearchingNumberInArray(int[] arr)
{
    int count = 0;
    foreach (int element in arr)
    {
        if (element >= 10 && element <= 99) count += 1;
    }
    System.Console.WriteLine($"answer is {count}");

}

int[] myArray = InitRandomArray(123, -200, 200);
PrintArray(myArray);
SearchingNumberInArray(myArray);