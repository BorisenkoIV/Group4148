// Задача № 19 hard (Dictionary)
// Определение Палиндрома для пятизначного числа с помощью Словаря

Console.WriteLine("\n  Задача № 19* (Словарь)");
Console.WriteLine("  Определение Палиндрома пятизначного числа");

int num5 = ReadData("  Введите пятизначное число:");

// 1 - Метод чтения данных с консоли:
int ReadData(string mess)
{
    Console.WriteLine(mess);
    int num5 = int.Parse(Console.ReadLine() ?? "0");
    // Проверяем, число пятизначное?
    if (num5< 10000 || num5 > 99999)
    {
       Console.WriteLine("Вы ошиблись...");
   // break;
    }
    return num5;
}
// Замолняем Словарь 4-х значными Палиндромами:
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
}
// Проверяем количество элементов в Словаре:
Console.WriteLine($"Count: {palindroms.Count}");

    // Вырезаем третью цифру пятизначного числа:
    int D1 = (num5 / 1000) * 100;
    int D4 = (num5 / 10) % 10 * 10;
    int D5 = num5 % 10;
    int num4 = (D1 + D4 + D5); // Получили 4-х значное число

    if (palindroms.ContainsValue(num4))
    {
        Console.WriteLine(num5 + " - Палиндром");
    }
    else
    {
        Console.WriteLine(num5 + " - это число не Палиндром");
    }



























// start:
// Console.WriteLine("  Введите пятизначное число:");
// int num5 = int.Parse(Console.ReadLine() ?? "0");

//  // Проверяем, число пятизначное?
//     if (num5< 10000 || num5 > 99999)
//     {
//        Console.WriteLine("Вы ошиблись...");
//        goto start;
//     }
// // Вырезаем третью цифру пятизначного числа:
// int D1 = (num5 / 1000) * 100;
// int D4 = (num5 / 10) % 10 * 10;
// int D5 = num5 % 10;
// int num4 = (D1 + D4 + D5); // Получили 4-х значное число
// // Для контроля выводим в консоль 4-х значное число:
// //Console.WriteLine(num4);

// Dictionary<int, int> palindroms = new Dictionary<int, int>();

// // Заполняем Словарь 4-х значными Палиндромами:
// for (int i = 1; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         int key = j * 10 + i;
//         int value = i * 1000 + j * 100 + j * 10 + i;
//         palindroms.Add(key, value);
//     }
// }
// // Проверяем количество элементов в Словаре:
// Console.WriteLine($"Count: {palindroms.Count}");

// // Проверяем число на Палидром:
// if (palindroms.ContainsValue(num4))
// {
//     Console.WriteLine(num5 + " - Палиндром");
// }
// else
// {
//     Console.WriteLine(num5 + " - это число не Палиндром");
// }

// // bool ContainsValue(V value): проверяет наличие элемента с определенным значением
// // и возвращает true при его наличии в словаре

// // проверяем количество элементов:
// //Console.WriteLine($"Count: {palindroms.Count}"); // Count: 0
