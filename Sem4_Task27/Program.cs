// Задача 27
/* Программа, которая принимает на вход число 'N'
        и выдаёт сумму цифр этого числа */

Console.Clear();
Console.WriteLine("Задача № 27");
Console.WriteLine("Ввод числа N, вывод числа цифр и суммы чисел от 1 до N");

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
void PrintResult(string message, long res)
{
    Console.WriteLine(message + res);
}

// Метод определения количества цифр в числе:
int CountDigit(int number)
{
    number = Math.Abs(number);
    int count = 0;
    while (number > 0)
    {
        count = count + 1;
        number = number / 10;
    }
    return count;
}

// Метод подсчета суммы цифр в числе N:
int SummaDigit(int number)
{
    number = Math.Abs(number);
    // Console.WriteLine(number);
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

int number = ReadData("  Введите число N:");
int res1 = CountDigit(number);
int res2 = SummaDigit(number);
PrintResult("Число цифр в числе: ", (int)res1);
PrintResult("Сумма цифр в числе: ", (int)res2);
