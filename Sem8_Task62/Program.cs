
/* Задача № 62
Написать программу, которая заполнит спирально массив 4 на 4. */

//using System.Threading;
Console.Clear();
Console.WriteLine("  Задача № 62");
Console.WriteLine("  Генерация и заполнение массива целыми числами по спирали:");

// Метод чтения даных с консоли:
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод вывода на печать 2х-мерного массива:
void Print2Darr(int[,] nums)
{
    // ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
    //                                     ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
    //                                     ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
    //                                     ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
    //                                     ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
    //                                     ConsoleColor.Yellow};
    // int row;
    // int col;

    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(nums[i, j] + " ");
            Console.ResetColor();
            Thread.Sleep(100);
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}

//Игорь Трибелустов
int[,] GenSpiralArray(int size)
{
    int[,] nums = new int[size, size];

    int num = 1;
    int i = 0;
    int x = 0;

    while (num <= size * size)
    {
        nums[i, x] = num;
        if (i <= x + 1 && i + x < size - 1) ++x;
        else if (i < x && i + x >= size - 1) ++i;
        else if (i >= x && i + x > size - 1) --x;
        else
            --i;
        ++num;
    }
    Print2Darr(nums);
    return nums;
}

DateTime d2 = DateTime.Now;
int N = ReadData("Введите размерность массива: ");
GenSpiralArray(N);
Console.WriteLine("Pешeние Игоря: " + (DateTime.Now - d2));

