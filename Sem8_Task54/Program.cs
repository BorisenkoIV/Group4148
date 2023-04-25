/*Задача № 54
Задать двумерный массив. Написать программу, которая упорядочит по убыванию
элементы каждой строки двумерного массива.*/

Console.Clear();
Console.WriteLine("  Задача № 54");
Console.WriteLine("  Упорядочить каждую строку в 2х-мерном массиве по убыванию:\n");

// Метод чтения данных:
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


// Метод сортировки каждой строки массива по убыванию:
int [,] SortString(int[,] arr, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        // Отсортируем строку методом Вставки:
        for (int j = 1; j < n; j++)
        {
            int sort = j - 1;
            while (sort > -1 && arr[i, sort] < arr[i, sort + 1])
            {
                int temp = arr[i, sort];
                arr[i, sort] = arr[i, sort + 1];
                arr[i, sort + 1] = temp;
                sort--;
            }
        }
    }
    return arr;
}


// Метод генерации 2х-мерного массива случайными числами:
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


// Метод печати двумерного массива:
void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 10, 99);
Console.WriteLine("  Исходный массив:");
Print2DArray(arr2D);
SortString(arr2D, row, col);
Console.WriteLine("  Отсортированный массив:");
Print2DArray(arr2D);
