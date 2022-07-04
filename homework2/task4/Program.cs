// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

System.Console.Write("Enter a number day of the week (from 1 to 7): ");
string daystr = Console.ReadLine();
int day = int.Parse(daystr);

if (day < 8 && day > 0) 
    {
        if (day == 6) System.Console.WriteLine("yes");
        else if (day == 7) System.Console.WriteLine("yes");
        else System.Console.WriteLine("no");
    }
else System.Console.WriteLine("the number is not a day of the week");