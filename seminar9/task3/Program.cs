// Задача 3: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int SumDigitsNumber(int number)
{
    if (number == 0)
    {
        return 0;
    }
    int sum = number % 10;
    return sum+=SumDigitsNumber(number / 10);
}

int sum = SumDigitsNumber(555);
System.Console.WriteLine(sum);