// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число: ");
int numb = int.Parse(Console.ReadLine()??"0"); //Получаем число и записываем его в переменную
int count = 2;

while (count<numb)
{
    Console.Write (count%2==0 ? count:", ");
    count ++; //счётчик
}
Console.Write (numb%2==0 ? numb:"");

