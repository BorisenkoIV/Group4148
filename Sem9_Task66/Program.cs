/* Задача 66 Метод рекурсии.
Ввод двух натуральных чисел M и N. 
Напишите программу, которая найдёт сумму натуральных чисел в промежутке от M до N. */


Console.Clear();
Console.WriteLine("  Задача № 66 Метод рекурсии.");
Console.WriteLine("  Вывод суммы натуральных чисел от 1 до N:");


// Метод чтения данных:
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод печати результата:
void PrintResult(int res)
{
    Console.Write("  Результат: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(res);
    Console.ResetColor();
}

// Метод подсчета суммы от N до M, рекурсией: 
int RequrSum(int a, int b, int sum)
{
    if (a <= b)
    {
        sum = sum + a;
        a++;
        return
        RequrSum(a, b, sum);
    }
    return sum;
}

int M = ReadData("Введите натуральное число M: ");
int N = ReadData("Введите натуральное число N: ");
RequrSum(M, N, 0);
int res = RequrSum(M, N, 0);
PrintResult(res);

