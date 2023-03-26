// Задача № 2.
Console.WriteLine("Задача № 2");

//Приглашение пользователю ввести первое число
Console.Write("Введите первое число и нажмите клавишу Enter: ");
 
//Получение первой строки
string? inputA = Console.ReadLine();
 if(inputA != null)
 {
    int numA = int.Parse(inputA);
 }
//Преобразование первой строки в число
//int argA = Convert.ToInt32(numberA);
 
//Приглашение пользователю ввести второе число
Console.Write("Введите второе число и нажмите клавишу Enter: ");
 
//Получение второй строки
string? inputB = Console.ReadLine();
if(inputB != null)
 {
     int numB = int.Parse(inputB);
 }
 
//Преобразование второй строки в число
//int argB = Convert.ToInt32(numberB);

//Приглашение пользователю ввести третье число
Console.Write("Введите второе число и нажмите клавишу Enter: ");
 
//Получение третьей строки
string? inputC = Console.ReadLine();
if(inputC != null)
 {
     int numC = int.Parse(inputC);
 }
 
//Преобразование третьей строки в число
//int argC = Convert.ToInt32(numberC);
 
//Сложение трех переменных
// int result = numA + numB + numC;
 
//Вывод результата
//Console.WriteLine("Результат сложения введенных чисел: " + result.ToString());
 
/*
* Обратите внимание на запись result.ToString(),
* тут мы преобразовали число в строку, вызвав
* метод ToString на переменной result!
* Этой операцией мы будем пользоваться часто. 
*/
