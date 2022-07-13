// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

// m = 0        >>>>>> n + 1
// m > 0, n = 0 >>>>>> f(m - 1, 1)
// m > 0, n > 0 >>>>>> f(m - 1, f(m, n - 1))

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Ackermann(int m, int n) 
{
    if (m == 0) return (n + 1);
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    if (m > 0 && n > 0) return Ackermann(m-1, Ackermann(m, n-1));
    return 0;
}

int number1 = Prompt("enter m: > ");
int number2 = Prompt("enter n: > ");
int result = Ackermann(number1,number2);
System.Console.WriteLine(result);