//Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position]);
//         position++;
//     }
// }

// int[] array = new int[3];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// Console.Write(array[0]);
// Console.WriteLine(array[2]);


int num = new Random().Next(100, 1000);
System.Console.WriteLine("random num = " + num);
int dig1 = 0;
int dig3 = 0;



dig3 = num % 10;
System.Console.WriteLine("3rd digit = " + dig3);

dig1 = num / 100;
System.Console.WriteLine("1st digit = " + dig1);

System.Console.WriteLine("result = " + dig1 + dig3);