// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int number = Prompt("Enter a number: ");
int count = 1;

while (count <= number)
{
    System.Console.Write(count*count + " ");
    count++;
}

