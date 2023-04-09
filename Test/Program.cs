// //Напишите программу, которая выводит третью цифру числа N

// Console.WriteLine("Bведите число");
// int number = int.Parse(Console.ReadLine() ?? "0"); //записы 
// int res = 0; // 

// if (number <= 99) // Проверяем число 
// {
//     Console.WriteLine("у числа нет третьей цифры"); // 
// }
// else
// {
//     /*if (number >= 100 && number <= 1000) // проверка числа на то больше и
//     {
//         int resFor = number % 10; // а после ищем отстатот остатка от
//         Console.WriteLine("Tpeтья цифра числа это: " + resFor);
//         break; //
//     }
//     else // если число больше 100 и больше 1000
//     {*/
//     int bufNum = number; // bufNam -промежуточное число...
//     int countR = 0; // countR - переменная в которой накапливается разряд числа
//     while (bufNum > 0)
//     {
//         bufNum = bufNum / 10;
//         countR++;
//     }
//     number = (int)(number / (Math.Pow(10, countR - 3)));
//     res = number % 10;
//     Console.WriteLine("Tpетья цифра числа это: " + res); //выводим результат на экран
// }

// //string s = "-12345";
// // 		int n;
// // 		bool isNumeric = int.TryParse(s, out n);

// // 		Console.WriteLine(n);
// // 		Console.WriteLine(isNumeric);
// Задача № 22 Вывести квадраты (кубы) целых чисел в диапазоне от 1 до N.
// Универсальный метод














// 


// // Инициализация массива строк
//       string[] daysOfWeek = { "Sunday", "Monday", "Tuersday","Wednesday", "Thirsday", "Friday", "Saturday" };

//       // Вывод массива строк AS в цикле
//       for (int i = 0; i < daysOfWeek.Length; i++)
//         Console.WriteLine("AS[{0}] = {1}", i, daysOfWeek[i]);
//       Console.ReadKey();



// // Ввод строк с клавиатуры
//       // и образование нового массива

//       // 1. Объявление переменных
//       string[] AS; // ссылка на массив строк
//       int count; // текущее количество строк в массиве
//       string s;
//       string[] AS2; // дополнительная переменная-ссылка - сохраняет старый массив строк

//       // 2. Цикл ввода строк
//       Console.WriteLine("Enter strings:");

//       count = 0; // обнулить количество строк
//       AS = new string[count]; // выделить память для 0 строк

//       do
//       {
//         // Ввести строку
//         s = Console.ReadLine();

//         // Проверка, пустая ли строка
//         if (s!="")
//         {
//           // если строка не пустая, то добавить строку в массив
//           count++;

//           // предварительно выделить память для нового массива
//           // в котором на 1 элемент больше
//           AS2 = new string[count];

//           // скопировать старый массив в новый
//           for (int i = 0; i < AS2.Length - 1; i++)
//             AS2[i] = AS[i];

//           // добавить последнюю введенную строку в массив AS2
//           AS2[count - 1] = s;

//           // Освобождать память, предварительно выделенную под AS не нужно,
//           // этим занимается сборщик мусора

//           // перенаправить ссылку AS на AS2
//           AS = AS2;
//         }
//       } while (s != "");

//       // 3. Вывод массива строк AS в цикле
//       for (int i = 0; i < AS.Length; i++)
//         Console.WriteLine("AS[{0}] = {1}", i, AS[i]);
//       Console.ReadKey();





string[] str = { "Это", "очень", "простой", "тест." };
		Console.WriteLine("Исходный массив: ");
		for(int i=0; i < str.Length; i++)
			Console.Write(str[i] + " ");
		Console.WriteLine("\n");
		// Изменить строку.
		str[1] = "тоже";
		str[3] = "до предела тест!";
		Console.WriteLine("Видоизмененный массив: ");
		for(int i=0; i < str.Length; i++)
			Console.Write(str[i] + " ");