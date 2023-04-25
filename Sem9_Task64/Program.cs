/* Задача 64 Метод рекурсии.
Задать значение N.
Написать программу, которая выведет в консоль все натуральные числа до N.*/

Console.Clear();
Console.WriteLine("  Задача № 64 Метод рекурсии.");
Console.WriteLine("  Вывод всех натуральных чисел от 1 до N:\n");

// Метод чтения данных:
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void PrintRequrN(int number, int currentnumber = 1)
{
    if (currentnumber > number) return;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(currentnumber + " ");
    PrintRequrN(number, currentnumber + 1);
}
int N = ReadData("Введите натуральное число: ");
PrintRequrN(N);
Console.ResetColor();
