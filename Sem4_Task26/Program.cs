/* //Чтение данных консоли
 int ReadData(string message)
 {
     Console.WriteLine(message);
     int res = int.Parse(Console.ReadLine() ?? "0");
     return res;
 }
 // Метод вывода результата
 void PrintResult(string msg, int res)
 {
     Console.WriteLine(msg+res);
 }
*/

// Задача № 26

/* Написать программу, которая принимает на вход 
число и выдаёт количество цифр в числе.
Пример: 456 -> 3, 78 -> 2, 89126 -> 5 */

Console.Clear();
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
void PrintResult(string message, long res)
{
     Console.WriteLine(message+res);
}

int CountDigit(int Number)
{
    int result = 0;
    while(Number>0)
    {
      result=result +1;
      Number = Number/10;              
    }
    return result ;
}

int numberA = ReadData("put number a: ");
int res1 = CountDigit (numberA );
PrintResult ("count:",(int)res1);
