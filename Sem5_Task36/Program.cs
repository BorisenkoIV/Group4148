/* Задача 36
  Задать массив чисел. Найти сумму элементов, стоящих на нечётных позициях в массиве: */

Console.Clear();
Console.WriteLine("Задача № 36");
Console.WriteLine("Вывод суммы элементов, стоящих на нечётных позициях в массиве:");

// Метод ввод числа:
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// Метод печати одномерного массива:
void Print1Darray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "; ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

/* Заполнение массива случайными значениями в диапазоне
 от минимального до максимального значения: */
int[] Gen1DArray(int len, int but, int top)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

// Метод подсчета суммы элементов, стоящих на нечётных позициях в массиве:
int SumEventPos(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum += arr[i];
    }
    Console.WriteLine("  Cумма элементов, стоящих на нечётных позициях в массиве:\n" + sum);
    return sum;
}

// Вывод результата:
int[] arr = Gen1DArray(20, 1, 10);
Console.WriteLine("   Неотсортированный массив:");
Print1Darray(arr);

//SumEventPos(arr);
//Console.WriteLine("  Cумма элементов, стоящих на нечётных позициях в массиве:");
SumEventPos(arr);
