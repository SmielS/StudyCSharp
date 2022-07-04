// Задача 2: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int SumOfRow(int[,] array, int row)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[row, j];
    }
    return sum;
}

int row = 4;
int column = 4;
int min = 0;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine();

int sum = 0;
int minrow = 0;

for (int i = 1; i < array.GetLength(0); i++)
{
    sum = SumOfRow(array, i - 1);
    if (SumOfRow(array, i) < SumOfRow(array, i - 1))
    {
        sum = SumOfRow(array, i);
        minrow = i;
    }
}

System.Console.WriteLine(minrow+1);
