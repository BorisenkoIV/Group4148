
// Console.WriteLine("\nЗадача № 38");
// Console.WriteLine("Вывод разности между максимальным и минмальным значением в вещественном массиве:");

// // Генерация вещественного одномерного массива:
// double[] Gen1DArrDouble(int len, int min, int max)
// {
//     double[] arr = new double[len];
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
//     }
//     Console.Write("\nРазность между Мак и Мин значением в вещественном массиве: ");
//     Console.WriteLine("{0:0.00}", arr.Max()- arr.Min());
//     return arr;
// }

// // Cортировка методом Подсчета:
// double CountingSort(double[] arr)
// {
//    double max = arr.Max();
//     double min = arr.Min();
//    // Console.WriteLine(arr.Max()-arr.Min());

//     double[] count = new double[max - min + 1];
//     double z = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         double count[arr[i] - min]++;
//     }
//     for (int i = min; i <= max; i++)

//         while (count[i - min]-- > 0)
//         {
//             arr[z] = i;
//             z++;
//         }
// }



// double [] tstArray = CountingSort();
// // Print1DArr(testArray);
// CountingSort(tstArray);

// /* Метод, выводящий на печать вещественный массиа
//    с округлением до двух знаков после запятой: */
// void Print1DArrOO(double[] arr)
// {
//     Console.Write("[");

//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         // выведет два знака после запятой
//         Console.Write("{0:0.00}", arr[i]);
//         Console.Write("; ");
//     }
//     Console.Write("{0:0.00}", arr[arr.Length - 1]);
//     Console.WriteLine("]");

// }


// // // поиск позиции (индекса), содержащего максимальное значение
// // //float B[30];
// // double FindMaxDouble(double[] tstArray)
// // double max; // переменная, содержащая максимум
// // int index; // позиция элемента, содержащего максимальное значение
// // int i; // дополнительная переменная
// // // поиск максимума
// // // установить максимум как 1-й элемент массива
// // index = 0;
// // max = tstArray[0];  //max = B[0]; 
// // for (i = 1; i < 30; i++)
// //     if (max < tstArray[i])    //B[i]) 
// //     {
// //         max = tstArray[i]; //B[i]; // запомнить максимум
// //         index = i;  // запомнить позицию максимального элемента
// //     }
// // return res;






// double[] testArray = Gen1DArrDouble(11, 100, 1000);
// Print1DArrOO(testArray);
// //CountingSort(testArray);
// //Print1DArrOO(testArray);
// //double[] tstArray =FindMaxDouble()



//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}



//Метод заполнение массива
int[,] Gen2DArray(int countRow, int countColumn, int but, int top)
{

    //Защита от дурака
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countRow; j++)
        {
            arr[i, j] = new Random().Next(but, top + 1);
        }

    }
    return arr;
}





//Метод печати 2 мерного массива 
void Print2DArray(int[,] arr)
{
    // ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
    //                                     ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
    //                                     ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
    //                                     ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
    //                                     ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
    //                                     ConsoleColor.Yellow};
    for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Green; //col[new Random().Next(0,16)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}


// //Метод печати 2 мерного массива 
// void Print2DArray(int[,] arr)
// {
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};
//     for (int i = 0; i < arr.GetLength(0); i++) //GetLength - до конца строки/столбца
//     {
//         for(int j=0; j < arr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = col[new Random().Next(0,16)];
//             Console.Write(arr[i,j]+" ");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }


// int row = ReadData("Введите кол-во строк: ");
// int col = ReadData("Введите кол-во столбцов: ");
// int[,] arr2D = Gen2DArray(row, col, 10, 99);
// //int[,] arr = FillNM2DArr(arr2D);
// Print2DArray(arr2D);



// Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
// Console.WriteLine("...");
// Console.ResetColor(); // сбрасываем в стандартный

int[,] matrix = new int[10, 12];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 12; j++)
                {
                    matrix[i, j] = i * 12 + j + 1;
                    
                    bool flag=true;
                    for (int w = 2; w < (i * 12 + j + 1)-1; w++) 
                    {
                        if (((i * 12 + j + 1) % w) == 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(i * 12 + j + 1);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(i * 12 + j + 1);
                    }
                     
                }
            Console.ReadLine();












// // поиск позиции (индекса), содержащего максимальное значение
// float B[30];
// float max; // переменная, содержащая максимум
// int index; // позиция элемента, содержащего максимальное значение
// int i; // дополнительная переменная

// // ввод массива
// // ...

// // поиск максимума
// // установить максимум как 1-й элемент массива
// index = 0;
// max = B[0];
// for (i = 1; i < 30; i++)
//     if (max < B[i])
//     {
//         max = B[i]; // запомнить максимум
//         index = i;  // запомнить позицию максимального элемента
//     }

















// // //Напишите программу, которая выводит третью цифру числа N

// // Console.WriteLine("Bведите число");
// // int number = int.Parse(Console.ReadLine() ?? "0"); //записы 
// // int res = 0; // 

// // if (number <= 99) // Проверяем число 
// // {
// //     Console.WriteLine("у числа нет третьей цифры"); // 
// // }
// // else
// // {
// //     /*if (number >= 100 && number <= 1000) // проверка числа на то больше и
// //     {
// //         int resFor = number % 10; // а после ищем отстатот остатка от
// //         Console.WriteLine("Tpeтья цифра числа это: " + resFor);
// //         break; //
// //     }
// //     else // если число больше 100 и больше 1000
// //     {*/
// //     int bufNum = number; // bufNam -промежуточное число...
// //     int countR = 0; // countR - переменная в которой накапливается разряд числа
// //     while (bufNum > 0)
// //     {
// //         bufNum = bufNum / 10;
// //         countR++;
// //     }
// //     number = (int)(number / (Math.Pow(10, countR - 3)));
// //     res = number % 10;
// //     Console.WriteLine("Tpетья цифра числа это: " + res); //выводим результат на экран
// // }

// // //string s = "-12345";
// // // 		int n;
// // // 		bool isNumeric = int.TryParse(s, out n);

// // // 		Console.WriteLine(n);
// // // 		Console.WriteLine(isNumeric);
// // Задача № 22 Вывести квадраты (кубы) целых чисел в диапазоне от 1 до N.
// // Универсальный метод














// // 


// // // Инициализация массива строк
// //       string[] daysOfWeek = { "Sunday", "Monday", "Tuersday","Wednesday", "Thirsday", "Friday", "Saturday" };

// //       // Вывод массива строк AS в цикле
// //       for (int i = 0; i < daysOfWeek.Length; i++)
// //         Console.WriteLine("AS[{0}] = {1}", i, daysOfWeek[i]);
// //       Console.ReadKey();



// // // Ввод строк с клавиатуры
// //       // и образование нового массива

// //       // 1. Объявление переменных
// //       string[] AS; // ссылка на массив строк
// //       int count; // текущее количество строк в массиве
// //       string s;
// //       string[] AS2; // дополнительная переменная-ссылка - сохраняет старый массив строк

// //       // 2. Цикл ввода строк
// //       Console.WriteLine("Enter strings:");

// //       count = 0; // обнулить количество строк
// //       AS = new string[count]; // выделить память для 0 строк

// //       do
// //       {
// //         // Ввести строку
// //         s = Console.ReadLine();

// //         // Проверка, пустая ли строка
// //         if (s!="")
// //         {
// //           // если строка не пустая, то добавить строку в массив
// //           count++;

// //           // предварительно выделить память для нового массива
// //           // в котором на 1 элемент больше
// //           AS2 = new string[count];

// //           // скопировать старый массив в новый
// //           for (int i = 0; i < AS2.Length - 1; i++)
// //             AS2[i] = AS[i];

// //           // добавить последнюю введенную строку в массив AS2
// //           AS2[count - 1] = s;

// //           // Освобождать память, предварительно выделенную под AS не нужно,
// //           // этим занимается сборщик мусора

// //           // перенаправить ссылку AS на AS2
// //           AS = AS2;
// //         }
// //       } while (s != "");

// //       // 3. Вывод массива строк AS в цикле
// //       for (int i = 0; i < AS.Length; i++)
// //         Console.WriteLine("AS[{0}] = {1}", i, AS[i]);
// //       Console.ReadKey();





// // string[] str = { "Это", "очень", "простой", "тест." };
// // 		Console.WriteLine("Исходный массив: ");
// // 		for(int i=0; i < str.Length; i++)
// // 			Console.Write(str[i] + " ");
// // 		Console.WriteLine("\n");
// // 		// Изменить строку.
// // 		str[1] = "тоже";
// // 		str[3] = "до предела тест!";
// // 		Console.WriteLine("Видоизмененный массив: ");
// // 		for(int i=0; i < str.Length; i++)
// // 			Console.Write(str[i] + " ");




// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }


// //Метод печати одномерного массива:
// void Print1Darray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ",");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// /*Заполнение массива случайными значениями в диапазоне
//  от минимального до мамаксимального значения:*/
// int[] Gen1DArray(int len, int top, int but)
// {
//     int[] res = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         res[i] = new Random().Next(but, top + 1);
//     }
//     return res;
// }

// // //инвертируем массив
// // int[] InvertArr(int[] arr, int len)
// // {
// //     for (int i = 0; i < len; i++)
// //     {
// //         arr[i] = arr[i] * (-1);
// //     }
// //     return arr;
// // }

// // void InversArrRef(int[] arr)
// // {
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //         arr[i] = arr[i] * (-1);
// //     }
// // }

// /////////////////////////////////////////////////
// int lenArr = ReadData("Введите длину массива: ");
// /////////////////////////////////////////////////

// // Метод сортировки - Пузырьком:
// void BubleArrRef(int[] arr)
// {
//     int len = lenArr;
//     while (len != 0)
//     {
//         int maxjndex = 0;
//         for (int i = 1; i < len; i++)
//         {
//             if (arr[i - 1] > arr[i])
//             {
//                 int temp = arr[i - 1];
//                 arr[i - 1] = arr[i];
//                 arr[i] = temp;
//                 maxjndex = i;
//             }
//         }
//         len = maxjndex;
//     }
// }

// // Метод сортировки - Выбром:
// void SelectionSort(int[] arr)
// {
//     int len = lenArr;
//     for (int i = 0; i < len - 1; i++)
//     {
//         int minjndex = i;
//         for (int j = i + 1; j < len; j++)
//         {
//             if (arr[minjndex] > arr[j])
//                 minjndex = j;
//         }
//         if (minjndex != i)
//         {
//             int temp = arr[minjndex];
//             arr[minjndex] = arr[i];
//             arr[i] = temp;
//         }
//     }
// }


// // Метод сортировки - Вставками:
// void InsertionSort(int[] arr)
// {
//     int len = lenArr;
//     for (int i = 1; i < len; i++)
//     {
//         int sorted = i - 1;
//         while (sorted > -1 && arr[sorted] > arr[sorted + 1])
//         {
//             int temp = arr[sorted];
//             arr[sorted] = arr[sorted + 1];
//             arr[sorted + 1] = temp;
//             sorted--;
//         }
//     }
// }


// // // Метод сортировки Хоара (быстрая сортировка):
// void SortHoara(int[] arr)
// int length = lenArr;
// int left = 0;
// int right = lenArr;
// int partOfSortHoara(int[] arr, int left, int right);
// // int length = lenArr;
// // int left=0;
// // int right=lenArr;
// {
//     int pivot = arr[(left + right) / 2];
//     while (left <= right)
//     {
//         while (arr[left] < pivot) left++;
//         while (arr[right] > pivot) right--;
//         if (left <= right)
//         {
//             int temp = arr[left];
//             arr[left] = arr[right];
//             arr[right] = temp;
//             left++;
//             right--;
//         }
//     }
//     return left;
// }
// void quickSortHoara(int[] arr, int start, int end)
// {
//     if (start >= end) return;
//     int rightStart = SortHoara(arr, start, end);
//     quickSortHoara(arr, start, rightStart - 1);
//     quickSortHoara(arr, rightStart, end);
// }
// void quickSortHoara(int[] arr)
// {
//     quickSortHoara(arr, 0, length - 1);
// }


// // Вывод результата:
// int[] arr = Gen1DArray(lenArr, 999, -999);
// Print1Darray(arr);
// BubleArrRef(arr);
// Print1Darray(arr);
// SelectionSort(arr);
// Print1Darray(arr);
// InsertionSort(arr);
// Print1Darray(arr);
// SortHoara(arr);
// Print1Darray(arr);


