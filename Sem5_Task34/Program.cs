/* Задача 34
Сгенерировать массив заполненный случайными положительными трёхзначными числами.
Вывести в консоль количество чётных чисел в массиве */
Console.Clear();
Console.WriteLine("Задача № 34");
Console.WriteLine("Вывести количество чётных чисел в массиве:");

// Метод чтения данных:
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод печати одномерного массива:
void Print1Darray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

/* Заполнение массива случайными значениями в диапазоне
 от минимального до максимального значения: */
int[] Gen1DArray(int len, int but, int top)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}


// Метод подсчета количества четных чисел в массиве:
int EvenCount(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res++;
        }
    }
    Console.WriteLine("Количество всех четных чисел в массиве:");
    return res;
}




// Метод сортировки массива Вставками:
void InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int sorted = i - 1;
        while (sorted > -1 && arr[sorted] > arr[sorted + 1])
        {
            int temp = arr[sorted];
            arr[sorted] = arr[sorted + 1];
            arr[sorted + 1] = temp;
            sorted--;
        }
    }
}


// //Метод инвертирсии массива:
// int[] InvertArr(int[] arr, int len)
// {
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = arr[i] * (-1);
//     }
//     return arr;
// }

// void InversArrRef(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] * (-1);
//     }
// }

/////////////////////////////////////////////////
int lenArr = ReadData("  Введите длину массива: ");
/////////////////////////////////////////////////

// Метод сортировки массива Пузырьком:
void BubleArrRef(int[] arr)
{
    int len = lenArr;
    while (len != 0)
    {
        int maxjndex = 0;
        for (int i = 1; i < len; i++)
        {
            if (arr[i - 1] > arr[i])
            {
                int temp = arr[i - 1];
                arr[i - 1] = arr[i];
                arr[i] = temp;
                maxjndex = i;
            }
        }
        len = maxjndex;
    }
}

// Метод сортировки массива Выбром:
void SelectionSort(int[] arr)
{
    int len = lenArr;
    for (int i = 0; i < len - 1; i++)
    {
        int minjndex = i;
        for (int j = i + 1; j < len; j++)
        {
            if (arr[minjndex] > arr[j])
                minjndex = j;
        }
        if (minjndex != i)
        {
            int temp = arr[minjndex];
            arr[minjndex] = arr[i];
            arr[i] = temp;
        }
    }
}

// Вывод результата:
int[] arr = Gen1DArray(lenArr, 100, 999);
Console.WriteLine("Неотсортированный массив:");
Print1Darray(arr);

BubleArrRef(arr);
Console.WriteLine("Метод сортировки  Пузырьком:");
Print1Darray(arr);

SelectionSort(arr);
Console.WriteLine("Метод сортировки  Выбром:");
Print1Darray(arr);

InsertionSort(arr);
Console.WriteLine("Метод сортировки  Вставками:");
Print1Darray(arr);

Console.WriteLine(EvenCount(arr));
//EvenCount(arr);

