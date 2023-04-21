/* Задача 50* (hard)
 Заполнть двумерный массив размерностью n×n числами Фибоначчи.
 Ввести с клавиатуры номер строки и номер позиции в строке.
 Вывести сообщение, если такого элемента в массиве нет.
 Подсветить найденый элемент в массиве */

Console.Clear();
Console.WriteLine("  Задача 50 hard");
Console.WriteLine("  Поиск элемента в массиве, заполненого числами Фибоначчи:");

// Метод чтения даных с консоли:
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод заполнения 2х-мерного массива числами Фибоначчи :
long[,] Fibonacci2Darr(int countRow, int countColumn)
{
    long[,] arr = new long[countRow, countColumn];
    long first = 0;
    long last = 1;
    int k = 0;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            if (k < 2)
            {
                arr[0, 0] = 0;
                arr[0, 1] = 1;
                k++;
            }
            else
            {
                arr[i, j] = (first + last);
                (first, last) = (last, first + last);
            }
        }
    }
    return arr;
}

// Метод поиска элемента в 2х-мерном массиве:
void FindElm(long[,] arr2D, int row, int col)
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
        Console.ResetColor();
        //Print2Darray(arr2D);
        //return;
    }
}

// Метод вывода на печать 2х-мерного массива:
void Print2Darray(long[,] arr)
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
    Console.WriteLine();
}

// Метод вывода на печать 2х-мерного массива с подсветкой:
void Print2DarrColor(long[,] arr, int x, int y)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == x && j == y)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(arr[x, y] + "\t");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(arr[i, j] + "\t");
                Console.ResetColor();
            }
        }
        Console.WriteLine();
    }
}

// Ввод даных для генерации массива и поиска элемента в массиве:
int row = ReadData("Введите количество строк исходного массива: ");
int col = ReadData("Введите количество столбцов исходного массива: ");
long[,] arr2D = Fibonacci2Darr(row, col);

int row0 = ReadData("Введите номер строки отыскиваемого элемента: ");
int col0 = ReadData("Введите позицию в строке отыскиваемого элемента: ");
FindElm(arr2D, row0, col0);
// Print2Darray(arr2D);
Print2DarrColor(arr2D, row0, col0);
