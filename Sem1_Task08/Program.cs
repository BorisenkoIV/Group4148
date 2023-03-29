// Задача № 8. Ввод натурального числа N. Вывод всех четных чисел от 1 до N.
Console.WriteLine("\n Задача № 8");
Console.WriteLine(" Ввод натурального числа N. Вывод всех четных чисел от 1 до N.");

//Выводим запрос на ввод числа N:
Console.WriteLine(" Введите число и нажмите Enter:");


//Считываем данные с консоли:
string? numLine = Console.ReadLine(); 

if (numLine != null)
{
    int numN = int.Parse(numLine);
    if (numN > 1)
    {
        int startNum = 2;

        // Создаем строковую переменную res, в которую будем добавлять новые значения:
        string res = string.Empty; //Empty - пуская строка

        // В цыкле добавляем четные числа в строковую переменную:
        while (startNum <= numN)
        {
            res = res + startNum + " ";
            startNum = startNum + 2;
        }
        // Выводим в консоль результат:
        Console.WriteLine(res);
    }
    else
    {
        Console.Write("Введите число > 1 и повторите ввод");
    }
}
