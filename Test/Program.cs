/* Задача № 58
Задать две двухмерные матрицы. 
Найти произведение этих матриц. Результат вывести в консоль. */

Console.Clear();
Console.WriteLine("  Задача № 58");
Console.WriteLine("  Найти произведение двух матриц:");

// Метод чтения данных:
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
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

// Метод печати двумерного массива:
void Print2Darray(int[,] arr)
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
    Console.WriteLine();
}

// Метод вывода на печать 2х-мерного массива с подсветкой:
void Print2DarrColor(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();

        }
        Console.WriteLine();
    }
}

// Метод произведения двух матриц:
int[,] Myltiply (int[,] arr1, int[,] arr2)
{

    int[,] arr0 = new int[arr1.GetLength(0),arr1.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j <arr1.GetLength(1); j++)
        {
            arr0[i, j] = arr1[i, j] * arr2[i, j]; // Произведение матриц
        }
    }
       return arr0;
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr1 = Gen2Darray(row, col, 5, 9);
int[,] arr2 = Gen2Darray(row, col, 5, 9);
Console.WriteLine("  Исходные массивы:");
Print2Darray(arr1);
Print2Darray(arr2);
Console.WriteLine("  Результирующий массив:");
Myltiply(arr1,arr2);
Print2DarrColor(Myltiply(arr1,arr2));
