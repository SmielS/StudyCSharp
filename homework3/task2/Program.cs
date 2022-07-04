// Задача 2: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int xa = Prompt("enter x of A: ");
int ya = Prompt("enter y of A: ");
int za = Prompt("enter z of A: ");
System.Console.WriteLine();

int xb = Prompt("enter x of B: ");
int yb = Prompt("enter y of B: ");
int zb = Prompt("enter z of B: ");
System.Console.WriteLine();


int a = xb - xa;
int b = yb - ya;
int c = zb - za;

double lenght = Math.Sqrt(a * a + b * b + c * c);
System.Console.WriteLine("lenght = " + lenght);
