﻿// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Variant1() //создаём первый метод
{
    Console.WriteLine("Способ 1");

    Console.Write("Введите номер дня недели: ");
    int NumbDay = int.Parse(Console.ReadLine()??"0");
    string [] WeekDays = new string [7]; //создаём коллекцию где номер дня недели соответствует результату
    WeekDays[0] = "Понедельник не является выходным";
    WeekDays[1] = "Вторник не является выходным";
    WeekDays[2] = "Среда не является выходным";
    WeekDays[3] = "Четверг не является выходным";
    WeekDays[4] = "Пятница не является выходным";
    WeekDays[5] = "Суббота является выходным";
    WeekDays[6] = "Воскресенье является выходным";
    Console.WriteLine (NumbDay<8&&NumbDay>0 ? WeekDays[NumbDay-1]: "Нет такого дня недели"); //выводим результат исходя из введёного номера исключая ошибки
}

void Variant2() //создаём второй метод
{
    Console.WriteLine("Способ 2");

    Console.Write("Введите номер дня недели: ");
    int NumbDay = int.Parse(Console.ReadLine()??"0");
    if (NumbDay<8&&NumbDay>0) //проверяем на ошибки введённое число
    {
        Console.WriteLine (NumbDay<6 ? "Этот день не выходной":"Этот день выходной"); //выводим результат
    }
    else Console.WriteLine ("Нет такого дня недели"); //результат в случае ошибки при вводе
}

Variant1(); //выводим первый метод
Variant2(); //выводим второй метод