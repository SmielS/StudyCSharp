int num = new Random().Next(100, 1000);
System.Console.WriteLine("random num = " + num);
int dig1 = 0;
int dig3 = 0;

dig3 = num % 10;
System.Console.WriteLine("3rd digit = " + dig3);

dig1 = num / 100;
System.Console.WriteLine("1st digit = " + dig1);

System.Console.WriteLine("result = " + dig1 + dig3);