// //Напишите программу, которая выводит третью цифру числа N

// Console.WriteLine("Bведите число");
// int number = int.Parse(Console.ReadLine() ?? "0"); //записы 
// int res = 0; // 

// if (number <= 99) // Проверяем число 
// {
//     Console.WriteLine("у числа нет третьей цифры"); // 
// }
// else
// {
//     /*if (number >= 100 && number <= 1000) // проверка числа на то больше и
//     {
//         int resFor = number % 10; // а после ищем отстатот остатка от
//         Console.WriteLine("Tpeтья цифра числа это: " + resFor);
//         break; //
//     }
//     else // если число больше 100 и больше 1000
//     {*/
//     int bufNum = number; // bufNam -промежуточное число...
//     int countR = 0; // countR - переменная в которой накапливается разряд числа
//     while (bufNum > 0)
//     {
//         bufNum = bufNum / 10;
//         countR++;
//     }
//     number = (int)(number / (Math.Pow(10, countR - 3)));
//     res = number % 10;
//     Console.WriteLine("Tpетья цифра числа это: " + res); //выводим результат на экран
// }

// //string s = "-12345";
// // 		int n;
// // 		bool isNumeric = int.TryParse(s, out n);

// // 		Console.WriteLine(n);
// // 		Console.WriteLine(isNumeric);
// Задача № 22 Вывести квадраты (кубы) целых чисел в диапазоне от 1 до N.
// Универсальный метод

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
        res += Math.Pow(i, pow) + "\t |";
    }
    return res;
}
int numN = ReadData("  Bведите чило N:");
Console.WriteLine("------------------------------------------");
//Console.WriteLine("|--------|-------|-------|-------|-------|");
Console.WriteLine("|"+LineGen(numN, 1));
Console.WriteLine("|--------|-------|-------|-------|-------|");
Console.WriteLine("|"+LineGen(numN, 2));
Console.WriteLine("|--------|-------|-------|-------|-------|");
Console.WriteLine("|"+LineGen(numN, 3));
Console.WriteLine("------------------------------------------");
