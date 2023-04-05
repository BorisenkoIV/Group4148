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

 int num = int.Parse(Console.ReadLine() ?? "0");
 int D1 = (num / 1000)*100;
 int D4 = (num / 10)%10*10;
 int D5 = num % 10;
 int namber=(D1+D4+D5);
 Console.WriteLine(D1+D4+D5);

Dictionary<int, int> FillPalindroms()
{
  Dictionary<int, int> palindroms = new Dictionary<int, int>();

    // Цикл внутри цикла, заполняющих значения словаря палиндромов
    for (int i = 1; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            int key = j * 10 + i;
            int value = i * 1000 + j * 100 + j * 10 + i;
            palindroms.Add(key, value);
        }
        return palindroms;
    }
    // Проверяем количество элементов в словаре:
    Console.WriteLine($"Count: {palindroms.Count}");
}