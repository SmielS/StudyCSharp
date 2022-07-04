// Задача 1: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5      7       -2     -0,2
// 1	   -3,3  	8      -9,9
// 8	    7,8	   -7,1 	9

double[,] GenerateDoubleArray(int row, int column, int min, int max)
{
    var array = new double[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1) + rnd.NextDouble();


        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j].ToString("0.#") + "\t");
        }
        System.Console.WriteLine();
    }
}

double[,] array = GenerateDoubleArray(4, 4, 0, 10);
PrintArray(array);