// Задача 1: Есть монотонная последовательность, каждое число встречается ровно
// то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
// Выведите ряд этой последовательности до N-го значения, желательно 
// использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void RowOfNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    RowOfNumbers(number-=1);
    for (int i = number; i > 0; i--)
    {
        Console.Write(number + ", ");
    }

}

int number = Prompt("enter a number: > ");
RowOfNumbers(number+=1);