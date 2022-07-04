// Задача 2: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// string BinaryCode = Convert.ToString(value, 2);


int InputNumber(string msg)
{
    System.Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return (number);
}



int number = InputNumber("enter a number");
string binary = Convert.ToString(number, 2);
System.Console.WriteLine(binary);