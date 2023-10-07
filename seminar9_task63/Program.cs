// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

int Read_Data (string start) //метод для получения числа N
{
    Console.WriteLine(start);
    int num = int.Parse(Console.ReadLine()??"0"); 
    return num;
}

void Gen_Line_Rec(int num) //метод для вывода чисел до 1, с рекурсией
{
    Console.Write(num+" ");
    if(num<=1)
    {
    }
    else
    {
       Gen_Line_Rec(num-1);
    }
}

int N = Read_Data ("Введите число:");
Gen_Line_Rec (N);