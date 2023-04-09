// // читаем число из консоли
// int topNum = TakeData("Введите целое число больше 0:  ");

// string LineBilder(int topNum, int pow, string initLine)
// {
//     string resLine = initLine;
//     int cube = 0;
//     for (int i = 0; i < topNum; i++)
//     {
//         cube = (int)Math.Pow(i, pow);

//         resLine = resLine + ((pow == 3) ? cube.ToString() : ((i).ToString()).PadRight((int)Math.Log10(cube) + 1)) + "\u2551";
//     }
//     return resLine;
// }
// string firstStr = LineBilder(topNum, 1, "\u2551 Число:	\u2551");

// int TakeData(string msg)
// { //метод считывающий целое число из консоли, выводя в неё сообщение Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// //string firstStr = LineBilder(topNum,1,"\u2551 Число:	\u2551");//
// Console.WriteLine(firstStr);

// string firstStr = LineBilder(topNum, 1, "\u2551 Число:	\u2551");
// string secStr = LineBilder(topNum, 3, "\u2551 куб числа: \u2551");
// DrawllniLine(firstStr, "\u2554", "\u2566", "\u2557");
// Console.WriteLine(firstStr);
// DrawllniLine(firstStr, "\u2560", "\u256C", "\u2563");
// ftnsole.WriteLine(secStr);
// DrawUniLine(firstStr, "\u255A", "\u2569", "\u255D");

// void DrawUniLine(string sampleStr, string startSym, string midSym, string stopSym)
// {
//     Console.Write(startSym); //рисуем левый верхний угол таблицы
//     int i = 1;
//     while (i < sampleStr.Length - 1)
//     {
//         if (sampleStr[i] == '\u2551') Console.Write(midSym); // если в строке с примером 
//         else Console.Write("\u2550"); // иначе рисуем горизонтальную линию
//         i++;
//     }
//     Console.WriteLine(stopSym); //рисуем правый верхний угол таблицы
// }

