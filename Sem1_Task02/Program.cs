// Задача № 2 Вывести на терминал максимальное и минимальное число двух целых чисел
Console.WriteLine("\n Задача № 2");
Console.WriteLine(" Вывести на терминал максимальное и минимальное число двух целых чисел");
Console.WriteLine(" Введите последовательно два числа, после каждого числа нажимать Enter");

string? inLine1 = Console.ReadLine();
string? inLine2 = Console.ReadLine();

if ((inLine1 != null) && (inLine2 != null))
{
    int inNumber1 = int.Parse(inLine1);
    int inNumber2 = int.Parse(inLine2);

    int max = inNumber1;
    int min = inNumber2;
    if (inNumber1 > inNumber2)
    {
        Console.WriteLine(" Максимальное число: " + max);
        Console.WriteLine(" Минимальное число: " + min);
    }
    else
    {
        Console.WriteLine(" Максимальное число: " + min);
        Console.WriteLine(" Минимальное число: " + max);
    }
}