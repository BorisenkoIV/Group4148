// Задача 5
Console.WriteLine("Hello, World! 04");

//Выводим запрос на ввод числа
Console.Write("Введите число: ");
//Считываем данные с консоли
string? numLine = Console.ReadLine(); //операционная система общается строками, поэтому int сразу не пишем

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
