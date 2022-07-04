// Задача 2: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindingNumberInArray(int[] arr, int number)
{
    foreach (int element in arr)
    {
        if (element == number) return true;
    }
    return false;
}

int number = 3;
System.Console.WriteLine("finding element is  "+number);
int[] myArray = InitArray(10, -5, 5);
PrintArray(myArray);
FindingNumberInArray(myArray, number);
System.Console.WriteLine(FindingNumberInArray(myArray, number)?"yes":"no");