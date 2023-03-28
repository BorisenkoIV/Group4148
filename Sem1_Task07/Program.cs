// Вывод на консоль последней цифры многозначного числа Задача № 7
Console.WriteLine("Задача № 7");

//Выводим запрос на ввод трехзначного числа
Console.Write("Введите трёхзначное число: ");
//Считываем данные с консоли
string? numLine = Console.ReadLine(); 

if(numLine!=null)
{
    // char[] charArr = numLine.ToCharArray();
   // Console.WriteLine(charArr[charArr.Line-1]);
    int num = int.Parse(numLine);
    int res = num % 10;

    Console.Write("Последняя цифра введённого числа: ");
    Console.Write(res);
}
