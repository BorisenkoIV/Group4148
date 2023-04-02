// Задача № 15 Dictionary
// Задача № 15hard Вводим число дня недели и проверяем является ли этот день выходным?

Console.WriteLine("\n Задача № 15 Dictionary");
Console.WriteLine(" Вводим число дня недели и проверяем является ли этот день выходным?\n");

Dictionary <int, string> daysOfWeek = new Dictionary<int, string>();

daysOfWeek.Add(1, "Будний день");
daysOfWeek.Add(2, "Будний день");
daysOfWeek.Add(3, "Будний день");
daysOfWeek.Add(4, "Будний день");
daysOfWeek.Add(5, "Будний день");
daysOfWeek.Add(6, "Выходной");
daysOfWeek.Add(7, "Выходной");

Console.Write(" Введите день недели (1-7): ");

int day = int.Parse(Console.ReadLine() ?? "0");

if (daysOfWeek.ContainsKey(day))
{
Console.WriteLine(daysOfWeek[day]);
}
else
{
Console.WriteLine(" Это не день недели!");
}
