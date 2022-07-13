// Задача 1: Напишите программу, которая на вход принимает два числа
// и выдаёт первые N чисел, для которых каждое следующее
// равно сумме двух предыдущих. 
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26 

long Prompt(string message)
{
    System.Console.Write(message);
    return long.Parse(Console.ReadLine());
}

long NextNumber(long num1, long num2, long next)
{
    if (next == 0) return 0;
    System.Console.WriteLine(num1);
    long temp = NextNumber(num2, num1 + num2, next - 1) + num1;
    return temp;
}


long num1 = Prompt("1st num: > ");
long num2 = Prompt("2nd num: > ");
long next = Prompt("Enter N: > ");


NextNumber(num1, num2, next);
