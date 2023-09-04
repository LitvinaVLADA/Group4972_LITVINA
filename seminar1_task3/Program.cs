// Задача №3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите номер дня недели: ");
int NumbDay = int.Parse(Console.ReadLine()??"0");
string [] WeekDays = new string [7];
WeekDays[0] = "Понедельник";
WeekDays[1] = "Вторник";
WeekDays[2] = "Среда";
WeekDays[3] = "Четверг";
WeekDays[4] = "Пятница";
WeekDays[5] = "Суббота";
WeekDays[6] = "Воскресенье";
Console.WriteLine (WeekDays[NumbDay-1]);
