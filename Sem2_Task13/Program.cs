
// Задача № 13 Вывод на консоль третьей цифры введенного числа

Console.WriteLine("\n Задача № 13");
Console.WriteLine(" Вывод на консоль третьей цифры многозначного числа");

// Выводим запрос на ввод трехзначного числа:
Console.WriteLine(" Введите многозначное число: ");

while (true)
{
    string? numLine = Console.ReadLine();

    // Проверяем количество символов в строке:
    if (numLine != null)// && (numLine.Length >= 3))
    {
        // Для контроля выводим на консоль:
        //Console.WriteLine(" Количество цифр введенного числа: {0}", numLine.Length);

        // Проверяем является ли введенная строка числом ?
        if (int.TryParse(numLine, out int number))
        {
            if (numLine.Length < 3)
            {
                Console.WriteLine(" Третьей цифры нет");
                break;
            }
            // Преобразуем введенную строку в символьный массив:
            char[] charArr = numLine.ToCharArray();
            // Проверяем первый символ в строке:
            if ( (charArr[0] == '-') || (charArr[0] == '+') )
            {
                // Выводим в консоль третью цифру многозначного числа: 
                Console.Write(" Третья цифра многозначного числа:\n" + charArr[3]);
                break;
            }
            // Выводим в консоль третью цифру многозначного числа: 
            Console.Write(" Третья цифра многозначного числа:\n" + charArr[2]);
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число!");
        }
    }
    Console.WriteLine("Введите пожалуйста многозначное число:");
}
