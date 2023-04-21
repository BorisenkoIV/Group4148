/* Задача 50
 Генерация двумерного массива размером m×n, заполненный случайными целыми числами.
 Ввести  номер строки и номер позиции в строке. Вывести сообщение, если такого элемента в массиве нет */

Console.Clear();
Console.WriteLine("  Задача № 50");
Console.WriteLine("  Поиск элемента в двухмерном массиве:");

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод генерирации 2х-мерного массива целых чисел:
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

// Метод вывода на печать 2х-мерного массива:
void Print2DarrColor(int[,] arr, int x, int y)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == x && j == y)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(arr[x, y] + " ");
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

void FindElm(int[,] arr2D, int row, int col)
{
    if (row >= arr2D.GetLength(0) || col >= arr2D.GetLength(1))
    {
        Console.WriteLine("  Такова элемента нет в массиве:");
        //return;
    }
    else
    {
        Console.WriteLine("  Ваш элемент в двухмерном массиве:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(arr2D[row, col]);
              //arr2D[row, col]=arr2D[row, col];
        Console.ResetColor();
        //Print2Darray(arr2D);
        //return;
    }
}

// Ввод даных для поиска элемента в массиве:
int[,] arr2D = Gen2Darray(10, 10, 10, 99);
int row = ReadData("Введите номер строки отыскиваемого элемента: ");
int col = ReadData("Введите позицию в строке отыскиваемого элемента: ");
FindElm(arr2D, row, col);
Print2DarrColor(arr2D, row, col);

