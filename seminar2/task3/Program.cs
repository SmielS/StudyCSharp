//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деление.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.Write("Введите 1 чило:");
string num1string = Console.ReadLine();
int num1int = int.Parse(num1string);
Console.Write("Введите 2 чило:");
string num2string = Console.ReadLine();
int num2int = int.Parse(num2string);

if (num1int % num2int == 0) System.Console.WriteLine("2 num / num1 = 0");
else System.Console.WriteLine(num1int = num1int%num2int);