// Задача № 22 Вывести квадраты (кубы) целых чисел в диапазоне от 1 до N.
// Универсальный Метод

int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
string LineGen(int num, int pow)
{
    string res = "";
    for (int i = 1; i <= num; i++)
    {
        res += Math.Pow(i, pow) + "\t";
    }
    return res;
}
int numN = ReadData("Bведите чило N: ");
Console.WriteLine(LineGen(numN, 1));
Console.WriteLine(LineGen(numN, 2));
Console.WriteLine(LineGen(numN, 3));
