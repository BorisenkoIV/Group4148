
/* Задача 36hard
  Задать массив чисел. Найти пары одинаковых элементов в массиве: */

Console.Clear();
Console.WriteLine("Задача № 36hard");
Console.WriteLine("Вывести пары одинаковых элементов в массиве:");

// Метод ввод числа:
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Заполнение массива:
int[] Gen1DArray(int size, int but, int top)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

// Метод печати одномерного массива
void Print1Darray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void PairElement(int size, int[] arr)
{
    bool pair = true; // Есть (нет) пары элементов.
    int n = 1;
    int m = 0;
    // Поиск парных элементов в массиве:
    for (int i = m; i < size - 1; i++) // Счетчик первого элемента
    {
        for (int j = n; j < size - 1; j++) // Счетчик второго элемента
        {
            if (arr[i] == arr[j])
            {
                Console.WriteLine("\tПара:  " + arr[i] + " " + arr[j]);
                Console.WriteLine("Индексы пары:  " + i + " " + (j));
                pair = false;
            }
        }
        n = n + 1;
        m = m + 1;
    }
    if (pair)
    {
        Console.Write("Таких пар нет...");
    }
}
// Генерация и печать исходного массива:
int size = ReadData("  Введите размер массива: ");
int[] arr = Gen1DArray(size, -20, 20);
Print1Darray(arr);

// Вызов Метода поиска парных элементов в массиве:
PairElement(size, arr);

