// Задача 2: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет	

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

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

int FindingPosition(int[,] array, int row, int column)
{
    int numberInPosition = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row && j == column) numberInPosition = array[i,j];
        }
    }
    return numberInPosition;
}

int[,] array = GenerateArray(5, 5, 0, 10);
PrintArray(array);

int row = Prompt("enter row: >");
int column = Prompt("enter column: >");

int number = FindingPosition(array, row-1, column-1);
if (number != -1) System.Console.WriteLine(number);
else System.Console.WriteLine("we havent this position");
