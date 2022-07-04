// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// System.Console.Write("enter a number: ");
// string numStr = Console.ReadLine();
// int numInt = int.Parse(numStr);

// if (numInt > -100 && numInt < 100) System.Console.WriteLine("number didin`t have 3rd digit");
// else if (numInt > -1000 && numInt < 1000) System.Console.WriteLine("3rd digital = " + numInt%10);
// else if (numInt > -10000 && numInt < 10000) System.Console.WriteLine("3rd digital = " +  numInt /10 %10);
// else if (numInt > -100000 && numInt < 100000) System.Console.WriteLine("3rd digital = " +  numInt /100 %10);
// else if (numInt > -1000000 && numInt < 1000000) System.Console.WriteLine("number more then i think");


System.Console.WriteLine("enter a number");
string numStr = Console.ReadLine();
int numInt = int.Parse(numStr);

while (numInt > 999 || numInt < -999) numInt = numInt / 10;

numInt = numInt % 10;
System.Console.WriteLine("3rd digit = " + numInt);