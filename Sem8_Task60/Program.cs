/* Задача № 60
Задать трехмерный массив. 
Вывести в консоль значение и индекс каждого элемента, в виде таблицы */

Console.Clear();
Console.WriteLine("  Задача № 60");
Console.WriteLine("  Вывод значения и индекс каждого элемента 3х-мерного массива:");

// Метод чтения данных:
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


// Метод генерации 3х-мерного массива случайными числами:
int[,,] Gen3Darray(int countList, int countRow, int countColumn, int minValue, int maxValue)
{
    int[,,] arr = new int[countList, countRow, countColumn];
    for (int k = 0; k < countList; k++)
    {
        for (int i = 0; i < countRow; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                arr[k, i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return arr;
}

// Метод печати 3х-мерного массива:
void Print3Darray(int[,,] arr)
{

    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(2); j++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(arr[k, i, j] + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    //Console.WriteLine();
}

// Метод вывода в консоль значения и индекса 3х-мерного массива:
void Print3Dindex(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(2); j++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(arr[k, i, j]);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("(" + k + "," + i + "," + j + ") ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int lis = ReadData("Введите количество листов: ");
int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,,] arr = Gen3Darray(lis, row, col, 10, 99);
Console.WriteLine("  Исходный 3х-мерный массив:");
Print3Darray(arr);
Console.WriteLine("  Результирующий 3х-мерный массив:");
Print3Dindex(arr);
