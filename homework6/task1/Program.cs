// Задача 1: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] InputArrayNumbers(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
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

int PositiveNumbers(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
        if (element > 0) count++;
    }
    return count;
}

System.Console.WriteLine("how many numbers we have?");
int lenght = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter a numbers through 'enter'");
int[] myArray = InputArrayNumbers(lenght);
PrintArray(myArray);
int result = PositiveNumbers(myArray);
System.Console.WriteLine("num of pos numbers = "+result);


