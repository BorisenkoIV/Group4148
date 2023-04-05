// Задача № 19 hard (Dictionary)
// Определение Палиндрома для пятизначного числа с помощью Словаря

Console.WriteLine("\n  Задача № 19* (Словарь)");
Console.WriteLine("  Определение Палиндрома пятизначного числа");

Console.WriteLine("  Введите пятизначное число:");
int num5 = int.Parse(Console.ReadLine() ?? "0");

// Вырезаем третью цифру пятизначного числа:
int D1 = (num5 / 1000) * 100;
int D4 = (num5 / 10) % 10 * 10;
int D5 = num5 % 10;
int num4 = (D1 + D4 + D5); // Получили 4-х значное число
Console.WriteLine(num4);    // Для контроля выводим в консоль

// Определение Палиндрома для пятизначного числа с помощью Словаря
// Метод, возвращающий словарь четырехзначных Палиндромов
Dictionary<int, int> FillPalindroms()// = new Dictionary<int, int>();
{
    Dictionary<int, int> palindroms = new Dictionary<int, int>();

    // Заполняем Словарь 4-х значными Палиндромами:
    for (int i = 1; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            int key = j * 10 + i;
            int value = i * 1000 + j * 100 + j * 10 + i;
            palindroms.Add(key, value);
        }
        return palindroms;
    }
    // Проверяем количество элементов в Словаре:
    Console.WriteLine($"Count: {palindroms.Count}");

    // palindroms.Add(1, 1001);
    // palindroms.Add(2, 2002);
    // palindroms.Add(3, 3003);
    // palindroms.Add(4, 4004);

    // Проверяем число на Палидром:
    if (palindroms.ContainsValue(num4))
    {
        Console.WriteLine(num5 + " - Палиндром");
    }
    else
    {
        Console.WriteLine(num5 + " - это число не Палиндром");
    }
    // проверяем количество элементов:
    Console.WriteLine($"Count: {palindroms.Count}");
}


// bool ContainsValue(V value): проверяет наличие элемента с определенным значением
// и возвращает true при его наличии в словаре

// проверяем количество элементов:
//Console.WriteLine($"Count: {palindroms.Count}"); // Count: 0
