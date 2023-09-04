// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int numb1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число: ");
int numb2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите третье число: ");
int numb3 = int.Parse(Console.ReadLine()??"0");
int max = numb1;

if (numb1>max) max=numb1;
if (numb2>max) max=numb2;
if (numb3>max) max=numb3;

if (numb1==max) Console.WriteLine("Самое большое число - первое - "+max);
if (numb2==max) Console.WriteLine("Самое большое число - второе - "+max);
if (numb3==max) Console.WriteLine("Самое большое число - третье - "+max);
