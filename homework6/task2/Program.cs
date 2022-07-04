// Задача 2. Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return double.Parse(param);
}

double XPointOfIntersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double YPointOfIntersection(double k1, double b1, double k2, double b2)
{
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    return y;
}

double b1 = Prompt("b1 = ");
double k1 = Prompt("k1 = ");
double b2 = Prompt("b2 = ");
double k2 = Prompt("k2 = ");
double x = XPointOfIntersection(k1, b1, k2, b2);
double y = YPointOfIntersection(k1, b1, k2, b2);
System.Console.WriteLine($"Point of intersection is ({x}, {y})");