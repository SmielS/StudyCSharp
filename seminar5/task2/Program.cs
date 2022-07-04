// Задача 1: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

void PrintArrayWithFeaturingChangingSign(int[] arr, int sign = 1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * sign;
        System.Console.Write($"{arr[i]}; ");
    }
    System.Console.WriteLine();
}

int[] myArray = InitArray(4, -9, 9);
PrintArrayWithFeaturingChangingSign(myArray, 1);
PrintArrayWithFeaturingChangingSign(myArray, -1);

