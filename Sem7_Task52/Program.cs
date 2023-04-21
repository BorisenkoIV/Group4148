/* Задача № 52*(hard)
   Задать двумерный массив размером m×n, заполненный случайными целыми числами.
   Найти среднее арифметическое элементов в каждом столбце. */

Console.Clear();
Console.WriteLine("  Задача № 52");
Console.WriteLine("  Среднее арифметическое элементов в каждом столбце:");

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод генерации 2х-мерного массива целых чилел:
int[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
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

// Метод вывода на печать 2х-мерного массива:
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод подсчета среднего арифметического в каждом столбце:
void SumColum(int[,] arr)
{
        for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        sum = sum / arr.GetLength(0);
        Console.Write(sum + "\t");
        Console.ResetColor();

    }
}

// Запрос исходных даных и вывод результата:
int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 10, 99);
Print2DArray(arr2D);
SumColum(arr2D);
