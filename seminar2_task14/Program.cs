﻿// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine()??"0");

Console.WriteLine (numb%7==0&&numb%23==0 ? "Число кратно 7 и 23":"Число не кратно 7 и/или 23");
