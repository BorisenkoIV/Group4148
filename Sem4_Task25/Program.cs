// Задача № 25
/* Программа, которая вводит натуральное число 'А' и 
   натуральное число 'b' и выводит число 'А' в степени 'b' */

using System.Numerics;

Console.Clear();
Console.WriteLine("Задача № 25");
Console.WriteLine("Ввод данных и вывод результата вычисления 'А' в степени 'b'");

// Метод чтения данных:
int ReadData(string message)
{
    int num = 0;
    // Console.WriteLine(message);
    // int res = int.Parse(Console.ReadLine() ?? "0");
    try
    {
        Console.WriteLine(message);
        int res = int.Parse(Console.ReadLine() ?? "0");
        return res;
    }
    catch (Exception)
    {
        Console.WriteLine("Это не число!");
        //Console.ReadLine(); // Ожидание ввода Enter.
        return num;
    }
}

// Метод печати результата:
void PrintResult(BigInteger res)
{
    Console.WriteLine("  Результат:\n" + res);
}

// Метод  возведения числа 'А' в степень 'b':
BigInteger StepenAinB(int A, int b)
{
    BigInteger res = 1;
    
    while (b > 0)
    {
        res = res * A;
        b = b - 1;
    }
    return res;
}

//Ввод данных и Вывод результата вычисления 'А' в степени 'b':
int A = ReadData("  Введите число А:");
int b = ReadData("  Введите степень b:");

BigInteger res1 = StepenAinB(A, b);
PrintResult(res1);

