// Задача 4: Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.

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

void Print2DArray(int[,] array)
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

int FindMinElement(int[,] array)
{
    int minNum = array[0, 0];
    foreach (int element in array)
    {
        if (element < minNum) minNum = element;
    }
    return minNum;
}

(int, int) FindIndexByValue(int[,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == value) return (i, j);
        }
    }
    return (0,0);
}

int[,] RemoveRowColumn(int[,] array2, int row, int column)
{
    int[,] newArr = new int[array2.GetLength(0) - 1, array2.GetLength(1) - 1];
    int k = 0;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        int l = 0;
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if ((i != row) && (j != column))
            {
                newArr[k, l] = array2[i, j];
                l++;
            }
        }
        if (i != row)
        {
            k++;
        }
    }
    return newArr;
}

int[,] array = GenerateArray(5, 5, 0, 9);
Print2DArray(array);
System.Console.WriteLine();

int minNum = FindMinElement(array);
System.Console.WriteLine(minNum);
System.Console.WriteLine();

(int row, int column) = FindIndexByValue(array, FindMinElement(array));

Print2DArray(RemoveRowColumn(array, row, column));
System.Console.WriteLine();
