Console.Write("enter a number =>");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);
Console.WriteLine("you entered number: " + paramInt);
int result = paramInt * paramInt;
Console.WriteLine($"result of x^2, where x({paramInt}) = {result}");

if (result > 20)
{
    Console.WriteLine("result > 20");
    Console.WriteLine("Bye!");
}
else
{
    Console.WriteLine("result < 20");
    Console.WriteLine("Byte-bye!");
}