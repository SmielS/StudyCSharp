// Задача 3: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9

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

void Print1DArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{i} = {arr[i]}; ");
    }
    System.Console.WriteLine();
}

int[] FreqencyOfNumbers(int[,] array)
{
    int[] freqArray = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            freqArray[array[i, j]]++;
        }
    }
    return freqArray;
}


int[,] array = GenerateArray(5, 5, 0, 9);
Print2DArray(array);
System.Console.WriteLine();

int[] freqArray = FreqencyOfNumbers(array);
Print1DArray(freqArray);
