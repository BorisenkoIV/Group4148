﻿
// Задача № 10 Вывод на консоль средней цифры введенного трехтзначного числа

Console.WriteLine("\n Задача № 10");
Console.WriteLine(" Вывод на консоль средней цифры трехзначного числа");

// Выводим запрос на ввод трехзначного числа:
Console.WriteLine(" Введите трехзначное число: ");

while (true)
{
    string? numLine = Console.ReadLine();
    
    // Проверяем количество символов в строке:
    if ((numLine != null) && (numLine.Length == 3))
    {
        // Для контроля выводим на консоль:
        //Console.WriteLine(" Количество цифр введенного числа: {0}", numLine.Length);

        // Проверяем является ли введенная строка числом ?
        if (int.TryParse(numLine, out int number))
        {
            // Преобразуем введенную строку в символьный массив:
            char[] charArr = numLine.ToCharArray();

            // Выводим в консоль среднюю цифру трехзначного числа: 
            Console.Write(" Средняя цифра трехзначного числа:\n" + charArr[1]);

            break;
        }
    }
    Console.WriteLine("Вы ошиблись, введите трехзначное число:");
}
