﻿// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write ("Введите трёхзначное число: ");
int numb = int.Parse(Console.ReadLine()??"0"); //Получаем число и записываем его в переменную

if (numb>99&&numb<1000) //проверяем на трёхзначность
{
    int result = (numb%100-numb%10)/10; //высчитываем какая цифра является второй
    Console.WriteLine (result);
}
else 
{
    Console.WriteLine("Число не трёхзначное. Повторите попытку."); //если число не трёхзначное выводим сообщение об ошибке
}
