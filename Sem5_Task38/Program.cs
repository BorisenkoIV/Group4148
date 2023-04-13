/* Задача 38
  Задать массив вещественных чисел. Найти разность между
  максимальным и минимальным  значением вещественного массива */
Console.Clear();
Console.WriteLine("Задача № 38");
Console.WriteLine("Вывод разности между максимальным и минимальным значением массива:");

// Генерация вещественного одномерного массива:
double[] Gen1DArrDouble(int len, int min, int max)
{
    double[] arr = new double[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
    }
    Console.Write("\n  Разность между Мак и Мин значением в вещественном массиве: ");
    Console.WriteLine("{0:0.00}", arr.Max() - arr.Min());
    return arr;
}
// Метод нахождения разности между Мак и Мин значением в вещественном массиве:
double DiffMaxMin(double[] arr)
{
    double res = 0;
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];
    }
    res = max - min;
    return res;
}

/* Метод, выводящий на печать вещественный массиа
   с округлением до двух знаков после запятой: */
void Print1DArrOO(double[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        // выведет два знака после запятой
        Console.Write("{0:0.00}", arr[i]);
        Console.Write("; ");
    }
    Console.Write("{0:0.00}", arr[arr.Length - 1]);
    Console.WriteLine("]");
}

double[] testArray = Gen1DArrDouble(11, 100, 1000);
Print1DArrOO(testArray);
Console.Write("\n  Разность между Мак и Мин значением в вещественном массиве: ");
Console.WriteLine(DiffMaxMin(testArray));

