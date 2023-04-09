// // Задача 27hard
// /* Программа, которая принимает на вход вещественное число 'N'
//         и выдаёт сумму цифр этого числа */

// Console.Clear();

// // Метод чтения данных:
// int ReadData(string message)
// {
//     Console.WriteLine(message);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }
// // Метод печати результата:
// void PrintResult(string message, long res)
// {
//     Console.WriteLine(message + res);
// }
// // Метод определения количества цифр в числе:
// int CountDigit(int Number)
// {
//     int count = 0;
//     while (Number > 0)
//     {
//         count = count + 1;
//         Number = Number / 10;
//     }
//     return count;
// }

// // Метод подсчета суммы цифр в числе N:
// int SummaDigit(int number)
// {
//     int sum = 0;
//     while (number != 0)
//     {
//         sum += number % 10;
//         number = number / 10;
//     }
//     return sum;
// }

// int numberN = ReadData("  Введите число N:");
// int res1 = CountDigit(numberN);
// int res2 = SummaDigit(numberN);
// PrintResult("Число цифр в числе: ", (int)res1);
// PrintResult("Сумма цифр в числе: ", (int)res2);




// // Метод чтения данных:
// int ReadData(string message)
// {
//     Console.WriteLine(message);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }



// int SummaDigit(double n)
// {
//     int t, p, sum1 = 0, sum2 = 0, sum = 0;
//     double z, intptr;
//     t = (int)n;
//     z = n - t;
//     while (t)
//     {
//         sum1 += t % 10;
//         t /= 10;
//     }

//     while (modf(z, & intptr) != 0)
//     {
//         z *= 10;
//     }
//     p = (int)z;
//     while (p)
//     {
//         sum2 += p % 10;
//         p /= 10;
//     }
//     sum = sum1 + sum2;

//     return sum;
// }

// double numberN = ReadData("  Введите число N:");
// int res2 = SummaDigit(numberN);