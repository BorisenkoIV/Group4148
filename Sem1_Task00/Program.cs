// Начало семинара: Знакомство с языками программирования.
// Задача № 0 Вывод в консоль квадрата введенного числа

Console.WriteLine("\n Задача № 0");
Console.WriteLine(" Вывод на консоль квадрата введенного числа");
Console.WriteLine(" Введите число и нажмите Enter");

//Считываем данные с консоли
string? inLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inLine != null)
{
    //Парсим введенное число
    int inNumber = int.Parse(inLine);

    //Находим квадрат числа (первый метод)
    int outNumber = inNumber * inNumber;
    
    // Второй метод нахождения квадрата числа (использование библиотеки)
    int outStrtPow = (int)Math.Pow(inNumber, 2);
    
    // Если читать код введенного числа непосредственно из памяти (ASCII)
    //int outNumberTest = inLine.ToCharArray()[0]*inLine.ToCharArray()[0];

    Console.WriteLine(" Выводим квадрат введенного числа:");
    // Выводим данные в консоль 
    Console.WriteLine(outNumber);
    // Выводим данные в консоль 
    Console.WriteLine(outStrtPow);
}
