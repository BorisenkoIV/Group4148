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

// Метод, генерирующий массив
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

void Print2Darray(int[,] arr)
{
    // ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
    //                                     ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
    //                                     ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
    //                                     ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
    //                                     ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
    //                                     ConsoleColor.Yellow};
    // int row;
    // int col;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //             if (int i == int j)
            //             {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
            // }
        }
        Console.WriteLine();
    }
}


//     Console.ForegroundColor = ConsoleColor.Green;
// Console.Write(arr[i, j] + " ");
// Console.ResetColor();
// }
// Console.WriteLine();
//     }
//     // Console.ForegroundColor = ConsoleColor.Yellow;
//     // Console.Write(arr[5, 5]);
//     // Console.ResetColor();

// //Метод печати 2мерного массива 
// void Print2Darray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             // if (i == j)
//             // {
//             //     Console.ForegroundColor = ConsoleColor.Yellow;
//             //     Console.Write(arr[i, j] + " ");
//             //     Console.ResetColor();
//             // }

//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }



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
        Print2Darray(arr2D);
        //return;
    }
}

int[,] arr2D = Gen2Darray(10, 10, 10, 99);
int row = ReadData("Введите номер строки двухмерного массива: ");
int col = ReadData("Введите номер элемента в строке двухмерного массива: ");
FindElm(arr2D, row, col);
int x = row;
int y = col;
//rint2Darray(arr2D);

//FindElm(arr2D, row, col);


//Метод построения чисел фибаначи
string FibNum(int num)
{
    string res = "0 1";
    long first = 0;
    long last = 1;

    for (int i = 2; i <= num; i++)
    {
        res = res + " " + (first + last);
        (first, last) = (last, last + first);
    }
    return res;
}


string res = "";
int n = ReadData("Введите n");
res = FibNum(n);
Console.WriteLine(res);





// int[,] arr2D = Gen2DArray(row, col, 10, 99);

// // Вывод результата:
// int[] arr = Gen1DArray(lenArr, 100, 999);
// Console.WriteLine("Неотсортированный массив:");

//Print1Darray(arr);

//Priny2DArray(arr2D);