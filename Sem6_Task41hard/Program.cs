/* Задача № 41hard
   Ввести с клавиатуры ограниченный набора любых символов и цифр (вкючая знак минус).
   Подсчитать количество нажатий на клавиатуре.
   Подсчитать количество положительных чисел в введенной строке. */

using System.Text.RegularExpressions; /* Без явного указания, не работают Регулярные выражения!*/

Console.Clear();
Console.WriteLine("Задача № 41");
Console.WriteLine("Считаем количество положительных чисел в введенной строке :");

int taps = ReadData("  Введите количество нажатий:");
string inputLine = ReadLineData("  Введите любые символы с клавиатуры:");
Console.WriteLine(inputLine);
FindNumbersInString(inputLine, taps);

// Метод чтения данных с консоли:
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод чтения данных с консоли и накопления считанных данных в строке:
string ReadLineData(string msg)
{
    Console.WriteLine(msg);
    string line = "";
    for (int i = 0; i < taps; i++)
    {
        /* Обьявляем переменную 'key' и присваиваем ей значение 'true',
        чтобы после нажатия клавиш ничего не отображалось в консоли : */
        ConsoleKeyInfo key = Console.ReadKey(true);
        line = line + String.Format(key.KeyChar.ToString());
    }
    return line;
}

/* Метод нахождения натуральных чисел в строке
  с применением Регулярных выражений: */
void FindNumbersInString(string str, int count)
{
    Regex regex = new Regex(@"(?<![-\d])\d+"); /* Отсекаем все числа меньше нуля */
    MatchCollection numbers = regex.Matches(str); /* Накапливаем числа */
    int posNums = 0;
    if (numbers.Count > 0) /* Подсчитываем количество найденых чисел */
    {
        foreach (Match match in numbers)
        {
            posNums = posNums + 1;
        }
        Console.WriteLine($"  Вы совершили нажатий: {count}\n  Среди введенных символов найдено чисел: {posNums}");
    }
    else
    {
        Console.WriteLine($"  Вы совершили нажатий: {count}\n  Среди введенных символов чисел не найдено!");
    }
}

