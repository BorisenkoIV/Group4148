/* Задача № 56
Задать двумерный массив. Написать программу, которая считает сумму элементов
в каждой строке и выдаёт номер строки с наименьшей суммой элементов.*/

Console.Clear();
Console.WriteLine("  Задача № 56");
Console.WriteLine("  Найти строку с наименьшей суммой элементов в строке:");

// Метод чтения данных:
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

int str = 0;
// Метод подсчета каждой строки с наименьшей суммой:
void MinSumRow(int[,] arr)//,int max )
{
    //int str = 0;
    int sum = int.MaxValue;

    for (int i = 0; i < arr.GetLength(0); i++)

    {
        int sumRow = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumRow = sumRow + arr[i, j];
        }
        if (sumRow < sum)
        {
            sum = sumRow;
            str = i;
        }
    }
    Print2DarrColor(arr);
    Console.Write("  Номер строки с минимальной суммой: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(str);
    Console.ResetColor();
    Console.Write("  Сумма строки: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(sum);
    Console.ResetColor();
}

// Метод генерации 2х-мерного массива случайными числами:
int[,] Gen2Darray(int countRow, int countColumn, int minValue, int maxValue)
{
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

// Метод вывода на печать 2х-мерного массива с подсветкой:
void Print2DarrColor(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == str)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(arr[i, j] + " ");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(arr[i, j] + " ");
                Console.ResetColor();
            }
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2Darray(row, col, 1, 9);
Console.WriteLine("  Исходный массив:");
MinSumRow(arr2D);

