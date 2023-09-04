// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Первое число: ");
int numb1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine ("Второе число: ");
int numb2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine (numb1<numb2 ? "Второе число больше - " + numb2: "Первое число больше - " + numb1);
