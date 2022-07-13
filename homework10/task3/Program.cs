// Задача 3*: Задача 1: Заполните спирально квадратный массив по возрастанию,
// с заданным размером:

// 1    2   3   4
// 12   13  14  5
// 11   16  15  6
// 10   9   8   7

int[,] SpiralArray(int m, int n)
{
    int[,] array = new int[m, n];
    int number = 1;
    for (int i = 0; i < m; i++)
    {
        array[0, i] = number;
        number++;
    }
    for (int j = 1; j < n; j++)
    {
        array[j, n - 1] = number;
        number++;
    }
    for (int k = n - 2; k >= 0; k--)
    {
        array[m - 1, k] = number;
        number++;
    }
    for (int l = m - 2; l > 0; l--)
    {
        array[l, 0] = number;
        number++;
    }
    // массив заполнен по часовой стрелке

    int m1 = 1;
    int n1 = 1;
    while (number < m * n)
    {
        while (array[m1, n1 + 1] == 0) // ->
        {
            array[m1, n1] = number;
            number++;
            n1++;
        }
        while (array[m1 + 1, n1] == 0) // v
        {
            array[m1, n1] = number;
            number++;
            m1++;
        }
        while (array[m1, n1 - 1] == 0) // <-
        {
            array[m1, n1] = number;
            number++;
            n1--;
        }
        while (array[m1 - 1, n1] == 0) // ^
        {
            array[m1, n1] = number;
            number++;
            m1--;
        }
    }
    // заполнено всё по спирали, кроме центра.

    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            if (array[x,y] == 0) array[x,y] = number;
        }
    }
    // циферка в центре

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

int[,] arr = SpiralArray(5, 5);
PrintArray(arr);