// Задача 29 
// Ввод одномерного массива с клавиатуры и вывод массива на консоль.
Console.WriteLine("\nЗадача № 29");
Console.WriteLine("Ввод одномерного массива с клавиатуры и вывод массива на консоль.");

// Метод чтения данных:
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод печати символьного массива:
void PrintStringArr(int[] myArray)
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
//myArray[i] = int.Parse(Console.ReadLine() ?? "0");
}
PrintStringArr(myArray);
