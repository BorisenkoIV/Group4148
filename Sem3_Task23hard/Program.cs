﻿// Задача № 23 hard
// Напишите программу, которая принимает на вход число N и выдаёт таблицу квадратов (кубов) чисел от 1 до N.
// * Вывести таблицу с границами и значениями друг над другом
//reads the string and output an integer
int ReadData(string msg)
{
    Console.Write(msg); return (int.Parse(Console.ReadLine() ?? "0"));
}  //forms a string of values 1->num powered by pw
string LineBuilder(int num, int pw)
{
    string res = "║";//String.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pw) + "\t║";
    }
    return res;
}
//forms a table borders of length Tab*num & depending on border position: "top", "middle" or "bottom"
string TableLineBuilder(int num, string linePosition)
{
    string res = String.Empty; int i; switch (linePosition)
    {
        case "top": res = "╔"; for (i = 1; i < num; i++) res = res + "═══════╦"; res = res + "═══════╗"; break;
        case "middle": res = "╠"; for (i = 1; i < num; i++) res = res + "═══════╬"; res = res + "═══════╣"; break;
        case "bottom": res = "╚"; for (i = 1; i < num; i++) res = res + "═══════╩"; res = res + "═══════╝"; break;
        default: for (i = 1; i <= num; i++) res = res + "════════"; break;
    }
    return res;
}
int num = ReadData("Ведите число: ");
Console.WriteLine(TableLineBuilder(num, "top"));
Console.WriteLine(LineBuilder(num, 1));
Console.WriteLine(TableLineBuilder(num, "middle"));
Console.WriteLine(LineBuilder(num, 2));
Console.WriteLine(TableLineBuilder(num, "middle"));
Console.WriteLine(LineBuilder(num, 3));
Console.WriteLine(TableLineBuilder(num, "bottom"));




// // Задача № 22 Вывести квадраты целых чисел в диапазоне от 1 до N.
// // Универсальный метод

// int ReadData(string message)
// {
//     Console.WriteLine(message);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }
// string LineGen(int num, int pow)
// {
//     string res = "";
//     for (int i = 1; i <= num; i++)
//     {
//         res += Math.Pow(i, pow) + "\t";
//     }
//     return res;
// }
// int numN = ReadData("Bведите чило N: ");
// Console.WriteLine(LineGen(numN, 1));
// Console.WriteLine(LineGen(numN, 2));
// Console.WriteLine(LineGen(numN, 3));
