// Задача № 7 Вывод на консоль последней цифры многозначного числа

Console.WriteLine("\n Задача № 7");
Console.WriteLine(" Вывод на консоль последней цифры многозначного числа");

//Выводим запрос на ввод трехзначного числа
Console.WriteLine(" Введите трёхзначное число:");
//Считываем данные с консоли
string? numLine = Console.ReadLine(); 

if(numLine!=null)
{
                 // char[] charArr = numLine.ToCharArray();
                // Console.WriteLine(charArr[charArr.Line-1]);
    int num = int.Parse(numLine);
    int res = num % 10;

    Console.Write("Последняя цифра введённого числа:\n"+ res);
    //Console.Write(res);
}
