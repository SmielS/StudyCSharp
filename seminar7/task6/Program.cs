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

(int, int) SumOfDiagonals(int[,] array)
{
    int countDiagonal = 0;
    int countReverseDiagonal = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) countDiagonal += array[i, j];
        }
    }
    int k = array.GetLength(1) - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        countReverseDiagonal += array[i, k];
        k--;
    }

    return (countDiagonal, countReverseDiagonal);
}

int row = 4;
int column = 4;
int min = 0;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine();

(int sumDiagonal, int sumReverseDiagonal) = SumOfDiagonals(array);
System.Console.WriteLine($"{sumDiagonal}, {sumReverseDiagonal}");

