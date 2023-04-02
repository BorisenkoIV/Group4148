// Задача № 19 Вводим пятизначное целое число, проверяем является ли введенное число Полидромом? 
// Проверяем количество символов в строке:

Console.WriteLine("\n Задача № 19");
Console.WriteLine(" Проверяем является ли введенное число Полидромом?");
Console.WriteLine(" Введите пятизначное целое число: ");

string? numLine = Console.ReadLine();
// Проверяем количество символов в строке:
if (numLine != null && (numLine.Length == 5))
{
    // Для контроля выводим на консоль:
    Console.WriteLine(" Количество цифр введенного числа: {0}", numLine.Length);
}

 int num = int.Parse(Console.ReadLine());
           Console.WriteLine(PalTest(num));
            Console.ReadKey(true);



bool PalTest(int nam)
{
    bool res = false;
    int D1 = num / 10000;
    int D5 = num % 10;
    int D2 = (num / 10000) % 10;
    int D4 = (num / 10) % 10;
    if (D1 == D5 && D2 == D4)
        return res;
}

/*
bool PalTest(int nam)
{
    bool res = false;
    int D1 = num / 10000;
    int D5 = num % 10;
    int D2 = (num / 10000) % 10;
    int D4 = (num / 10) % 10;
    if (D1 == D5 && D2 == D4)
        return res;
}
//return res;
*/
