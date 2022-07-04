// Задача 1: Напишите программу, которая перевернёт 
//одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArray(int len, int min, int max)
{
    var array = new int[len];
    var rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (var e in array)
    {
        System.Console.Write(e + " ");
    }
    System.Console.WriteLine();
}

int[] ReverseArray(int[] array)
{
    for(var i = 0; i < array.Length/2; i++){
        var tmp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = tmp;
    }

    return array;
}

int[] ReverseCopyArray(int[] array)
{
    int[] reverse = new int[array.Length];
    for(var i = 0; i < array.Length; i++){
        reverse[array.Length-1-i] =  array[i];
    }

    return reverse;
}

int[] myArr = CreateArray(4, 1, 10);
System.Console.WriteLine("Исходный массив");
PrintArray(myArr);
System.Console.WriteLine("Реверс копи");
PrintArray(ReverseCopyArray(myArr));
System.Console.WriteLine("Исходный массив");
PrintArray(myArr);
System.Console.WriteLine("Реверс");
PrintArray(ReverseArray(myArr));
System.Console.WriteLine("Исходный массив");
PrintArray(myArr);
