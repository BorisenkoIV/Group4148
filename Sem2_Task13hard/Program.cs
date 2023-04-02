// Задача № 13hard (не использовать char)
// Вывод на консоль третьей цифры введенного числа (не более 10 знаков!)

start:
Console.WriteLine("  Введите число не менее 3-х и не более 10-и знаков:");

// Проверяем является ли строковая переменная числом?
if (int.TryParse(Console.ReadLine()!, out int nunLine))
{
    // Проверяем число на: не менее 3-х и не более 10-и знаков!
    // Число не должно начинаться с нуля!
    if (nunLine > 999999999 || nunLine < 100)
    {
        Console.WriteLine("Введите правильно число!");
        goto start;
    }
    // Находим третью цифру слева.
    int Third(int nunLine)
    {
        while (nunLine >= 1000) nunLine /= 10;
        int n = nunLine % 10;
        return n;
    }
    // Выводим в консоль третью цифру слева.
    Console.WriteLine("  Третья цифра слева:\n" + Third(nunLine));
}
else
{
    Console.WriteLine("Это не число!");
    goto start;
}
