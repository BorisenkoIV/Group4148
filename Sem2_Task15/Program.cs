﻿// Задача № 15* Вводим число дня недели и проверяем является ли этот день Выходным или Будничным днем?
Console.WriteLine("\n Задача № 15");
Console.WriteLine(" Вводим число дня недели и проверяем является ли этот день Выходным?\n");
Console.Write(" Введите день недели (1-7): ");

string? dayLine = Console.ReadLine(); //Обьявляем символьную переменную: dayLine

if (dayLine != null) //Проверяем, символьная переменная:'dayLine' не 'null
{

    {
        int day = int.Parse(dayLine); // Преобразуем символьную переменную:'dayLine' в числовую переменную: 'day'

        if ((1 <= day) && (day <= 5)) //Проверяем является ли введенное число Будним днем?
        {
            Console.WriteLine("Будний день");
        }
        else
        {
            if ((5 < day) && (day < 8)) //Проверяем является ли введенное число Выходным днем?
            {
                Console.WriteLine("Выходной день");
            }
            else // Любое другое введенное число отлчиное от 1 до 7, Ошибка!
            {
                Console.WriteLine("Неправильный день недели");
            }
        }
    }
}