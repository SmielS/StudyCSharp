// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

//сумма любых двух его сторон больше третьей стороны.

int InputSide()
{
    System.Console.WriteLine("Введите сторону");
    int side = int.Parse(Console.ReadLine());

    return (side);
}

bool Check(int s1, int s2, int s3)
{
    return (s1 + s2 > s3 && s2 + s3 > s1 && s3 + s1 > s2);
}

int side1 = InputSide();
int side2 = InputSide();
int side3 = InputSide();
System.Console.WriteLine(Check(side1,side2,side3));