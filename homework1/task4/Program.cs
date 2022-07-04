// Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.

Console.Write("Enter a number: ");
string numberString = Console.ReadLine();
int numberInt = int.Parse(numberString);
int start = 1;
if (numberInt < start) 
    Console.WriteLine("incorrect input number");
while (start <= numberInt)
{
        if (start % 2 == 0)
            Console.Write(start + " ");
    start ++;
}

