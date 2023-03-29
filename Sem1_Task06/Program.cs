
/* Задача № 6 Прием на входе числа и вывод на консоль - является ли это число
 четным и делится ли оно на два без остатка*/
  
Console.WriteLine ("\n Задача № 6");
Console.WriteLine (" Ввод целого числа. Вывод результата анализа на четность и остаток от деления на два");

//Выводим запрос на ввод числа
Console.WriteLine(" Введите целое число и нажмите Enter:");
//Считываем данные с консоли
string? numLine = Console.ReadLine();

if (numLine != null)
{
    // char[] charArr = numLine.ToCharArray();
    // Console.WriteLine(charArr[charArr.Line-1]);
    int num = int.Parse(numLine);
    int res = num %2;
    if (res == 0)
    {
        Console.Write("Введенное число: " + num + " четное");
    }
    else
    {
        Console.Write("Введенное число: " + num + " делится на два с остатком");
    }
}