// Задача № 21 Найти растояние между двумя точками А и В в пространстве 3D

Console.WriteLine("\n Задача № 21");
Console.WriteLine("Найти растояние между двумя точками А и В в пространстве 3D");


int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// Находим расстояние между точками A(x1,y1,z1) и B(x2,y2,z2) в пространстве 3D:

// Применяем 
double CalcLen3D(int x1, int y1, int z1, int x2, int y2, int z2)
// Находим расстояние между точками А и В в пространстве 3D:
{
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
}
// Применяем Метод ReadData:
int xl = ReadData(" Введите	координату  x1  точки A:");
int y1 = ReadData(" Введите	координату  y1  точки А:");
int z1 = ReadData(" Введите	координату  z1  точки А:");

int x2 = ReadData(" Введите	координату  x2  точки В:");
int y2 = ReadData(" Введите	координату  y2  точки В:");
int z2 = ReadData(" Введите	координату  z2  точки В:");

Console.WriteLine("  Pacтояние между точками А и В:\n" + CalcLen3D(xl, y1, z1, x2, y2, z2));
