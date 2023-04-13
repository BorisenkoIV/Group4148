/* Задача № 38hard 
   Вывод разности между максимальным и минмальным значением в вещественном массиве. */

Console.Clear();
Console.WriteLine("Задача № 38hard");
Console.WriteLine("Отсортировать вещественный массив методом Вставки:");

// Генерация вещественного одномерного массива:
double[] Gen1DArrDouble(int len, int min, int max)
{
    double[] arr = new double[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
    }
    Console.Write("\nРазность между Мак и Мин значением в вещественном массиве: ");
    Console.WriteLine("{0:0.00}", arr.Max() - arr.Min());
    return arr;
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

// InsertionSort(arr);
// Console.WriteLine("  Метод сортировки  Вставками:");
// Print1DArrOO(arr);

// Метод сортировки массива Вставками:
void InsertionSort(double[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int sorted = i - 1;
        while (sorted > -1 && arr[sorted] > arr[sorted + 1])
        {
            double temp = arr[sorted];
            arr[sorted] = arr[sorted + 1];
            arr[sorted + 1] = temp;
            sorted--;
        }
    }
}


// Метод нахождения разности между Мак и Мин значением в вещественном массиве:
double DiffMaxMin(double[] arr)
{
    double res = 0;
    res = arr[arr.Length - 1] - arr[0];
    return res;
}


double[] testArray = Gen1DArrDouble(11, 100, 999);
Console.WriteLine("  Исходный неотсортированный массив:");
Print1DArrOO(testArray);
InsertionSort(testArray);
Console.WriteLine("  Отсортированный массив методом Вставки:");
Print1DArrOO(testArray);
Console.Write("  Разность между Мак и Мин значением в вещественном массиве: ");
Console.WriteLine(DiffMaxMin(testArray));


