// Задача 2: В некотором машинном алфавите имеются четыре буквы
//  «а», «и», «с» и «в». Покажите все слова, состоящие из n букв,
// которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, 
// ав, ва, ви, ив, св, вс

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

string[] alphabet = new string[] { "а", "и", "с", "в" };

void PrintAllWordsLenghtN(string[] array, string pref, int count = 4)
{
    if (count == 0)
    {
        System.Console.WriteLine(pref);
        return;
    }
    for (int i = 0; i < 4; i++)
    {

        PrintAllWordsLenghtN(array, pref + array[i], count - 1);
    }
}

PrintAllWordsLenghtN(alphabet, "", 7);