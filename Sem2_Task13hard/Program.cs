
// Задача № 13hard Вывод на консоль третьей цифры введенного числа

Console.WriteLine("\n Задача № 13hard");
Console.WriteLine(" Вывод на консоль третьей цифры многозначного числа");

// Выводим запрос на ввод многозначного числа:
//Console.WriteLine(" Введите многозначное число:");

Console.WriteLine("Введите трехзначное число");
        int.TryParse(Console.ReadLine()!, out int k);
    
        if ( k > 999 || k < 100 )
        {
        Console.WriteLine("Не трехзначное число!!!");
        //return;
        }
        int GetSecond(int k)
        {
        while (k >= 1000000) k /= 100;
        int d = k % 10;
        return d;
        }
        Console.WriteLine(GetSecond(k));



//static void Main(string[] args)
//{
/*
    int n = 1934534623;
    int d = GetSecondDigit(n);
    Console.WriteLine(d);
    Console.ReadKey();
//}

static int GetSecondDigit(int k)
{
    while (k >= 100) k /= 10;
    int d = k % 10;
    return d;
}
*/
/*
while (true)
{
    string? numLine = Console.ReadLine();

    // Проверяем количество символов в строке:
    if (numLine != null)// && (numLine.Length >= 3))
    {
        // Для контроля выводим на консоль:
        Console.WriteLine(" Количество цифр введенного числа: {0}", numLine.Length);

        // Проверяем является ли введенная строка числом ?
        if (int.TryParse(numLine, out int number))
        {
            if (numLine.Length < 3)
            {
                Console.WriteLine(" Третьей цифры нет");
                break;
            }
            // Преобразуем введенную строку в символьный массив:
           /*
            char[] charArr = numLine.ToCharArray();
            // Проверяем первый символ в строке:
            if ( (charArr[0] == '-') || (charArr[0] == '+') )
            {
                // Выводим в консоль третью цифру многозначного числа: 
                Console.Write(" Третья цифра многозначного числа:\n" + charArr[3]);
                break;
            }
            // Выводим в консоль третью цифру многозначного числа: 
            Console.Write(" Третья цифра многозначного числа:\n" + charArr[2]);
            break;
            
        }
        else
        {
            Console.WriteLine("Вы ввели не число!");
        }
    }
    Console.WriteLine("Введите пожалуйста многозначное число:");
}
*/
//int n=10;
//while (i < n)
  //      {
    //       Console.WriteLine("Введите элемент массива");
        /* Вводим элементы массива с клавиатуры 
         * и заполняем ими массив */
       //    Data[i] = double.Parse(Console.ReadLine());
     //      Console.WriteLine();
   //        i++;
 //       }
