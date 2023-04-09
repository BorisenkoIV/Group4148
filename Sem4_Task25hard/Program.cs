// Задача № 25hard
/* Программа, которая вводит натуральное число 'А' и 
   натуральное число 'b' и выводит число 'А' в степени 'b' */

using System.Numerics;

Console.Clear();
Console.WriteLine("\nЗадача № 25hard");
Console.WriteLine("Ввод данных и вывод результата вычисления калькулятора");

// // Метод чтения данных:
// int ReadData(string message)
// {
//     Console.WriteLine(message);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// Метод чтения данных:
int ReadData(string message)
{
    int num = 1;
    try // Проверка вводимих данных на число?
    {
        Console.WriteLine(message);
        int res0 = int.Parse(Console.ReadLine() ?? "0");
        return res0;
    }
    catch (Exception)
    {
        Console.WriteLine("Это не число!");
        //Console.ReadLine(); // Ожидание ввода Enter.
        return num;
    }
}
// Метод определения арифметической операции:
// int Operazh(string message)
// {
//     Console.WriteLine(message);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     //char znak =  Console.ReadLine(znak);

// Проверка ввода Операции через if:
// if (res == '+')
// {
//     int sum = a + b;
//     Console.WriteLine(sum);
// }
// else if (znak == '-')
// {
//     //Console.WriteLine(firstValue - secondValue);
// }
// else if (znak == '*')
// {
//     //Console.WriteLine(firstValue * secondValue);
// }
// else if (znak == '/')
// {
//     //Console.WriteLine(firstValue / secondValue);
// }
// else if (znak == '!')
// {
//     //Console.WriteLine(firstValue ! secondValue);
// }
//     return res;
// }

// Метод печати результата:
void PrintResult(string message, BigInteger res)
{
    Console.WriteLine(message + res);
}

// Метод  возведение числа 'a' в степень 'b':
BigInteger StepenAinB(int a, int b)
{
    BigInteger res = 1;

    while (b > 0)
    {
        res = res * a;
        b = b - 1;
    }
    return res;
}
// Метод  вычисление разности чисел (a-b):
long RaznostAiB(int a, int b)
{
    long res = a - b;
    return res;
}
// Метод  вычисление суммы чисел (a+b):
long SummaAiB(int a, int b)
{
    long res = a + b;
    return res;
}

// Метод  вычисление произведения чисел: (a*b):
long ProisvAnaB(int a, int b)
{
    long res = a * b;
    return res;
}

// Метод  вычисления частного чисел: a/b (b>0):
long ChastnAnaB(int a, int b)
{
    long res = a / b;
    // double res = a / b;
    return res;
}

//Ввод данных и Вывод результата вычисления 'А' в степени 'b':
int a = ReadData("  Введите число: a");
int b = ReadData("  Введите число: b");
//int znak = ReadData("  Выберите onepauию: '+' '-' '*' '/' '!'");
//int res0 = Operazh(c);
long res1 = RaznostAiB(a, b);
long res2 = SummaAiB(a, b);
long res3 = ProisvAnaB(a, b);
long res4 = ChastnAnaB(a, b);
BigInteger res5 = StepenAinB(a, b);
//PrintResult("Операция: = ", res0);
PrintResult("Разность чисел: a-b = ", res1);
PrintResult("Сумма чисел: a+b = ", res2);
PrintResult("Произведение чисел: a*b = ", res3);
PrintResult("Частное чисел: a/b = ", res4);
PrintResult("Степень числа: (a)b = ", res5);

