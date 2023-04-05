
// МЕТОД РЕШЕНИЯ 2:
// Задача № 20 Найти растояние между двумя точками А и В на плоскости 2D

Console.WriteLine("\n Задача № 20");
Console.WriteLine("Найти растояние между двумя точками А и В на плоскости 2D\n");

int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0"); return res;
}
// Находим расстояние между точками А(х1.у1) и В(х2,у2) на плоскости 2D:

// Принимаем 
double CalcLen2D(int xl, int yl, int x2, int y2)

// Находим расстояние между точками А(х1.у1) и В(х2,у2) на плоскости 2D:
{
    return Math.Sqrt(Math.Pow((xl - x2), 2) + Math.Pow((yl - y2), 2));
}
// Применяем Метод ReadData:
int xl = ReadData("  Введите координату x1 точки A:");
int yl = ReadData("  Введите координату у1 точки А:");
int x2 = ReadData("  Введите координату х2 точки В:");
int y2 = ReadData("  Введите координату у2 точки В:");

Console.WriteLine("  Pacтояние между точками А и В:\n" + CalcLen2D(xl, yl, x2, y2));
