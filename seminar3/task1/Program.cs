//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.


int Prompt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x = Prompt("enter x: ");
int y = Prompt("enter y: ");

if (x == 0 || y == 0)
{
    System.Console.WriteLine("x or y is 0");
}

if (x > 0 && y > 0)
{
    System.Console.WriteLine("1st part");
}

if (x < 0 && y > 0)
{
    System.Console.WriteLine("2nd part");
}

if (x < 0 && y < 0)
{
    System.Console.WriteLine("3rd part");
}

if (x > 0 && y < 0)
{
    System.Console.WriteLine("4th part");
}