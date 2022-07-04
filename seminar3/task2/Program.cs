// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int part = Prompt("enter number of part");

if (part == 1) System.Console.WriteLine("x > 0 and y > 0");
if (part == 2) System.Console.WriteLine("x < 0 and y > 0");
if (part == 3) System.Console.WriteLine("x < 0 and y < 0");
if (part == 4) System.Console.WriteLine("x > 0 and y < 0");
else System.Console.WriteLine("you didnt entered number of part");