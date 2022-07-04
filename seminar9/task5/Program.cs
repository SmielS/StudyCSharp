// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

// bool PowCheck(int number, int degree)
// {
//     if (number == degree) return true;
//     if (number < 2) return false;
//     return PowCheck(number / degree, degree);
// }

// System.Console.WriteLine(PowCheck(1024, 2));

bool IsPower2(int val)
{
    return ((val) & (val-1)) == 0;
}
System.Console.WriteLine(IsPower2(32));
