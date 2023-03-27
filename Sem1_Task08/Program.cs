// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? inLine1 = Console.ReadLine();
string? inLine2 = Console.ReadLine();
if ((inLine1 != null) && (inLine2 != null))
{
    int inNumber1 = int.Parse(inLine1);

    int inNumber2 = int.Parse(inLine2);

    int outNumber2 = inNumber2 * inNumber2;

    if (outNumber2 == inNumber1)
    {
        Console.WriteLine("Да является");
    }
    else
    {
        Console.WriteLine("Не является");
    }

}
