// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x1 = Prompt("enter x of A: ");
int y1 = Prompt("enter y of A: ");
int x2 = Prompt("enter x of B: ");
int y2 = Prompt("enter y of B: ");
int a = x1 - x2;
int b = y1 - y2;
double lenght = Math.Sqrt(a * a + b * b);
System.Console.WriteLine("lenght in 2d = " + lenght);

