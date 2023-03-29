// Задача №5 Ввод натурального числа N и Вывод на консоль Целых чисел в диапазоне -N до +N

Console.WriteLine ("\n Задача № 5");
Console.WriteLine (" Ввод натурального числа N. Вывод на экран целых чисел в диапазоне -N до +N ");

Console.WriteLine (" Введите число: "); //Выводим запрос на ввод числа N

//операционная система общается строками, поэтому int сразу не пишем!
string? numLine = Console.ReadLine(); //Считываем данные с консоли

if(numLine!=null)
{
    int numN = int.Parse(numLine);

    int startNum = numN*(-1);

    string res = string.Empty;
    
    while(startNum <= numN)
    {
        res = res + startNum + " ";
        startNum++;
    }
    Console.WriteLine(res);

}
