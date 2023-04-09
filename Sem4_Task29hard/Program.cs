// Задача 29hard
// Ввод одномерного массива с клавиатуры и вывод массива на консоль.
Console.WriteLine("\nЗадача № 29hard");
Console.WriteLine("Ввод одномерного массива с клавиатуры и вывод массива на консоль.");


// Метод чтения данных:
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод печати одномерного массива
void Print1DArr(int[] myArray)
{
    Console.Write("[");
    for (int i = 0; i <myArray.Length - 1; i++)
    {
        Console.Write(myArray[i] + ",");
    }
    Console.WriteLine(myArray[myArray.Length - 1] + "]\n");
}

int elementsCount= ReadData("  Введите количество элементов в массиве:\t");

int[] myArray = new int[elementsCount];
for (int i = 0; i < myArray.Length; i++)
{
Console.Write($"  Введите элемент массива с индексом {i}:\t");
myArray[i] = int.Parse(Console.ReadLine() ?? "0");
}

Print1DArr(myArray);




//  // Метод генерации одномерного массива случайными числами
// int[] Gen1DArr(int len, int top, int but)
// {
//     int[] res = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         res[i] = new Random().Next(but, top + 1);
//     }
//     return res;
// }




// Console.Write("Введите количество элементов в массиве:\t");
// int elementsCount = int.Parse(Console.ReadLine());

// //int MyArray (myArr[elemCount] );
// int[] myArray = new int[elementsCount];
// for (int i = 0; i < myArray.Length; i++)
// {
// //Console.Write($"Введите элемент массива с индексом {i}:\t");
// myArray[i] = int.Parse(Console.ReadLine());
// }
// int SerchElementInArr(int[] arr)
// {
//     int count = 0;
//     int minValue = 10;
//     int maxValue = 99;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= minValue && arr[i] <= maxValue)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] testArr = Gen1DArr(123, 1000, 1);
// Print1DArr(testArr);
// Console.WriteLine(SerchElementInArr(testArr));

// int lenArr = ReadData("Введите длину массива: ");
// int[] arr = Gen1DArray(lenArr,9,-9);
// Print1Darray(arr);
// int num = ReadData("Введите искомый элемент: ");
// SearchElmArr(arr, num);

// Console.Write("Введите количество элементов в массиве:\t");
// int elementsCount = int.Parse(Console.ReadLine());

// int elementsCount  = ReadData("Введите количество элементов в массиве:\t");
//int res1 = MyArray(elementsCount);


// Console.WriteLine("\nВывод массива:");
// for (int i = 0; i < myArray.Length; i++)
// {
// Console.WriteLine(myArray[i]);
// }
// Console.ReadLine();
