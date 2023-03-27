// See
Console.WriteLine("Введите три числа разделенных одним пробелом и нажмите Enter");

/*string[] num = Console.ReadLine().Split(' ');
int a = int.Parse(num[0]);
int b = int.Parse(num[1]);
int c = int.Parse(num[2]);
*/

string? inLine1 = Console.ReadLine();
string? inLine2 = Console.ReadLine();
string? inLine3 = Console.ReadLine();

if ((inLine1 != null) && (inLine2 != null) && (inLine3 != null))
{
    int inNumber1 = int.Parse(inLine1);
    int inNumber2 = int.Parse(inLine2);
    int inNumber3 = int.Parse(inLine3);

    if (inNumber1 > inNumber2)
    {
        int max = inNumber1;

        if (inNumber1 > inNumber3)
        {
           Console.WriteLine("\n Максимальное число: " + max);
           goto End;
        }
    }
    if (inNumber2 > inNumber3)
    {
        int max = inNumber2;
        Console.WriteLine("\n Максимальное число: " + max);
    }
    else
    {
    int max = inNumber3;
    Console.WriteLine("\n Максимальное число: " + max);
    }
End:
    Console.WriteLine("Финиш");
}


