// Задача 4: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] Multiplication(int[] arr)
{
    int[] array = new int[arr.Length / 2];
    int multi = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        multi = arr[i] * arr[arr.Length - i -1];
        for (int j = 0; j < array.Length; j++)
        array[i] = multi;
    }
    return array;
}

int[] myArray = InitRandomArray(5, 1, 5);
PrintArray(myArray);
int[] newArray = Multiplication(myArray);
PrintArray(newArray);