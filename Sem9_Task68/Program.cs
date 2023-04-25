
/* Задача 68
Заданы два натуральных числа N и M.
Написать программу, которая вычисляет функцию Аккермана с помощью рекурсии.*/

Console.Clear();
Console.WriteLine("  Задача № 68 Метод рекурсии.");
Console.WriteLine("  Вычисление функция Аккермана с помощью рекурсии:");

ulong Akkerman(ulong n, ulong m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        Console.ForegroundColor = ConsoleColor.Yellow;
    return Akkerman(n - 1, Akkerman(n, m - 1));

}

Console.WriteLine(Akkerman(2, 3));
Console.ResetColor();
Console.WriteLine(Akkerman(3, 2));
Console.ResetColor();
Console.WriteLine(Akkerman(3, 4));
Console.ResetColor();
