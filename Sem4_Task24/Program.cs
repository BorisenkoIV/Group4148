// Задача № 24 

/* Напишите программу, которая принимает на вход 
число (А) и выдаёт сумму чисел от 1 до А.
Например: 7 -> 28, 4 -> 10, 8 -> 36 */

Console.WriteLine("\n Задача № 24");
Console.WriteLine("Подсчет суммы чисео от 1 до А");

// Метод чтения данных с консоли:
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;     // вывод результата метода
}
// Метод вывода результата в консоль:
void PrintResult(string msg, int res)
{
    Console.WriteLine(msg+res);
}
// Метод подсчета суммы чисел от 1 до А:
long SumSimple(int numA)
{
    long sum = 0;
    for(int i =1; i<=numA;i++)
    {
        sum+=i;
        //sum=sum+i;
    }
    return sum;     // вывод результата метода
}
 // Метод подсчета суммы чисел от 1 до А - методом Гаусса:
long SumGauss(int numA)
{
    return ((1+(long)numA)*(long)numA)/2;
}

int numberA=ReadData("  Введите число A: ");

// Таймер реального времени выполнения программы:
DateTime d1 = DateTime.Now;
long res1 = SumSimple(numberA);     // вызов метода
Console.WriteLine(DateTime.Now - d1);

// Таймер реального времени выполнения программы:
DateTime d2 = DateTime.Now;
long res2 = SumGauss(numberA);    // вызов метода 
Console.WriteLine(DateTime.Now - d2);

// Вывод результата метода:
PrintResult("  Сумма чисел от 1 до A (простой метод): ", (int)res1);
PrintResult("  Сумма чисел от 1 до A (метод  Гаусса): ", (int)res2);
