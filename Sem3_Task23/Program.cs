// Задача № 23
// Напишите программу, которая принимает на вход число N и выдаёт таблицу квадратов (кубов) чисел от 1 до N.

Console.WriteLine("\n  Задача № 23");
Console.WriteLine("  Вывод кубов (квадратов) числа N от 1 до N");

// Метод чтения даных
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// Метод возведения числа в степень
string LineGen(int num, int pow)
{
    string res = "";
    for (int i = 1; i <= num; i++)
    {
        res += Math.Pow(i, pow) + "\t";
    }
    return res;
}

int numN = ReadData("  Bведите чило N:");
Console.WriteLine(LineGen(numN, 1)); // Вывод чисел от 1 до N
Console.WriteLine(LineGen(numN, 2)); // Вывод квадратов чисел от 1 до N
Console.WriteLine(LineGen(numN, 3)); // Вывод кубов чисел от 1 до N