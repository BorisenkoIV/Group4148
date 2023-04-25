using System.Threading;

// //метод печати двумерного массива
// void Print2DArray(int[,] arr)
// {
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = col[new Random().Next(0, 16)];
//             Console.Write(arr[i, j] + " ");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Right(int n)
// {
//     //int n = 5;
//     int i = 0;
//     int[,] myArray = new int[n, n];

//     for (int j = 0; j < n - 2; j++)
//     {
//         arr[i, j] = new Random().Next(minValue, maxValue + 1);

//         return arr;
//     }
// }
// int n = 7;
// //int N=2;
// int[,] myArray = new int[n, n];
// int i = 0; // y < myArray.GetLength(0); y++)

//     for (int j = 0; j < n-2; j++)
//     {
//         myArray[i, j]=j+1;
//         Console.Write(myArray[i, j]+" ");
//     }
//     Console.WriteLine();


// Первый проход:
// i=0; j=0; j<n-2; j++  // с лева - на право
// i=0; j=n-1; i<n-2; i++ // с верху - в низ
// i=n-1; j=n-1; j>0; j--  // с права - на лево
// i=n-1; j=0; i>0; i--  // с низа - в верх

// int[,] myArray = new int[10, 10];
// for (int y = 0; y < myArray.GetLength(0); y++)
// {
//     for (int x = 0; x < myArray.GetLength(1); x++)
//     {
//         Console.Write(myArray[y, x]+" ");
//     }
//     Console.WriteLine();
// }



// int row = ReadData("Введите количество строк: ");
// int col = ReadData("Введите количество столбцов: ");
// // int[,] arr2D = Gen2DArray(row,col,10,99);
// int row = ReadData("Введите количество строк: ");
// Right(row);
// Priny2DArray(arr2D);

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
            Thread.Sleep(200);
        }
        Console.WriteLine();
    }
    // Console.ForegroundColor = ConsoleColor.Yellow;
    // Console.WriteLine();
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
    //Print2Darr(nums);
    return nums;
}

//DateTime d2 = DateTime.Now;
//int[,] arr2D = GenSpiralArray(siz);
int N = ReadData("Введите размерность массива: ");
GenSpiralArray(N);
//Console.WriteLine("Pешe Ивана" + (DateTime.Now - d2));
//Print2Darr(nums);


// int m = ReadData("Введите количество строк: ");
// int n = ReadData("Введите количество столбцов: ");
// int[j] arr = Gen2DSpiralArray(m);
// Print2DSpiralarray(arr);

// // Простые числа:
// int [,] Fib2Darr(int countRow, int countColumn)
// {
// int[,] arr = new int [countRow,  countColumn];
// for (int i = 0; i < countRow; i++)
//     for (int j = 0; j < countColumn; j++)
//     {
//         arr[i, j] = i * countColumn + j + 1;

//         // bool flag = true;
//         // for (int w = 2; w < (i * countColumn + j + 1) - 1; w++)
//         // {
//         //     if (((i * countColumn + j + 1) % w) == 0)
//         //     {
//         //         flag = false;
//         //         break;

//         //     }
//         // }
//         // if (flag)
//         // {
//         //     Console.ForegroundColor = ConsoleColor.Red;
//         //     //Console.Write(i * 6 + j + 1+" ");
//         //     Console.ResetColor();
//         // }
//         // // else
//         // // {
//         // //     Console.WriteLine(i * countColumn + j + 1);
//         // // }

//     }
//     return arr;
// //Console.ReadLine();
// }

// // Ввод даных для генерации массива и поиска элемента в массиве:
// int row = ReadData("Введите количество строк исходного массива: ");
// int col = ReadData("Введите количество столбцов исходного массива: ");
// int [,] arr2D = Fib2Darr(row, col);

// int row0 = ReadData("Введите номер строки отыскиваемого элемента: ");
// int col0 = ReadData("Введите позицию в строке отыскиваемого элемента: ");
// FindElm(arr2D, row0, col0);
// Print2Darr(arr2D);
//Print2DarrColor(arr2D, row, col);
