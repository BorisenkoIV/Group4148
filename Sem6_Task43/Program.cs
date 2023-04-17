/* Задача № 43/
/* Найти точки пересечения 3 прямых линий, 
   заданных уравнениями: y=k1*x+b1, y=k2*x+b2 и  y=k3*x+b3;
   Значения: b1, b2, b3, k1, k2 и k3 задаются пользователем */

Console.Clear();
Console.WriteLine("Задача 43");
Console.WriteLine("Найти точки пересечения 3 прямых:");


// Запрос данных для уравнения:
double K1 = ReadData("  Введите число K1: ");
double B1 = ReadData("  Введите число B1: ");
double K2 = ReadData("  Введите число K2: ");
double B2 = ReadData("  Введите число B2: ");
double K3 = ReadData("  Введите число K3: ");
double B3 = ReadData("  Введите число B3: ");

// Поиск координат пересечения:
(double x, double y) pointA = CrossPoint(K1, B1, K2, B2);
(double x, double y) pointB = CrossPoint(K2, B2, K3, B3);
(double x, double y) pointC = CrossPoint(K3, B3, K1, B1);

double X1 = pointA.x;
double Y1 = pointA.y;
double X2 = pointB.x;
double Y2 = pointB.x;
double X3 = pointC.x;
double Y3 = pointC.x;

// Вывод результатов вычислений:
PrintData($"Координаты пересечения трех линий:\n  X1= {X1};\t Y1= {Y1};\n  X2= {X2};\t Y2= {Y2};\n  X3= {X3};\t Y3= {Y3};");
double sideA = TriangleSide(X1, Y1, X2, Y2);
double sideB = TriangleSide(X2, Y2, X3, Y3);
double sideC = TriangleSide(X3, Y3, X1, Y1);

// Метод чтения данных с консоли:
double ReadData(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных в консоль:
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Комплексный метод:
(double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
{
    double coorX1 = (b2 - b1) / (k1 - k2);
    double coorY1 = (k1 * b2 - k2 * b1) / (k1 - k2);
    return (coorX1, coorY1);
}
// Находим стороны пересечения линий:
double TriangleSide(double x1, double y1, double x2, double y2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return result;
}
