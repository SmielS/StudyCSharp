// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

//rnd.Next(min, max+1)+rnd.NextDouble()
double[] InitRandomArray(int len, int min, int max)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max+1)+rnd.NextDouble();
    }
    return arr;
}

void PrintArray(double[] arr)
{
    foreach (int element in arr)
    {
        System.Console.Write($"{element}; ");
    }
    System.Console.WriteLine();
}

double FindingMaxElementsOfArray(double[] arr)
{
    double max = arr[0];
    foreach(int element in arr)
    {
        if (element > max) max = element;
    }
    return(max);
}

double FindingMinElementsOfArray(double[] arr)
{
    double min = arr[0];
    foreach(int element in arr)
    {
        if (element < min) min = element;
    }
    return(min);
}

double[] myArray = InitRandomArray(5,0,10);
PrintArray(myArray);
System.Console.WriteLine($"max element of array is {FindingMaxElementsOfArray(myArray)}, min element is {FindingMinElementsOfArray(myArray)}. Differential between of them is {FindingMaxElementsOfArray(myArray) - FindingMinElementsOfArray(myArray)}");
