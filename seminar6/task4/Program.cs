// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int InputNumber(string msg)
{
    System.Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return (number);
}

int Fibonacci(int n)
{
    int first = 0;
    int second = 1;
    int result = 0;
    if (n == 0) return 0;
    if (n == 1) return 1;
    System.Console.Write(first + " ");
    System.Console.Write(second + " ");
    for (int i = 2; i < n; i++)
    {
        result = first + second;
        System.Console.Write(result + " ");
        first = second;
        second = result;
    }
    return result;
}

int n = InputNumber("enter 'n'");
Fibonacci(n);