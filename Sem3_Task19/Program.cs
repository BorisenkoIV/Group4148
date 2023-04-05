// Задача № 19 Вводим пятизначное целое число, проверяем является ли введенное число Палидром? 
// Проверяем количество символов в строке:

Console.WriteLine("\nЗадача № 19 (метод)");
Console.WriteLine("  Проверяем является ли введенное число Палидром?");
int numLine = ReadData("  Введите пятизначное число: ");

bool num = PalTest(numLine);

// Метод чтения данных с консоли:
int ReadData(string mess)
{
    Console.WriteLine(mess);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод проверки числа на Палидром:
bool PalTest(int num)
{
    bool res = false;
    int D1 = num / 10000;
    int D5 = num % 10;
    int D2 = (num / 1000) % 10;
    int D4 = (num / 10) % 10;
    if (D1 == D5 && D2 == D4)
        res = true;
    Console.WriteLine("Результат: " + res);
    return res;
}
