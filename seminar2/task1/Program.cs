Console.Write("Введите чило:");
string numstring = Console.ReadLine();
int numint = int.Parse(numstring);

if (numint < 99 && numint > 100 || numint < -1000 && numint > -99 ) Console.WriteLine("incorrect input");
else Console.WriteLine("Last number: " + numint % 10);