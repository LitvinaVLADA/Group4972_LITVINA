// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int Read_Data (string start) //метод для получения числа
{
    Console.WriteLine(start);
    int num = int.Parse(Console.ReadLine()??"0"); 
    return num;
}

int Sum_Natural_Elements (int m, int n) //метод для суммирования чисел в заданном промежутке
{
    if (m == n)
    {
        return m;
    }
    else if (m > n)
    {
        return n + Sum_Natural_Elements(n + 1, m);
    }
    else
    {
        return m + Sum_Natural_Elements(m + 1, n);
    }
}

int N = Read_Data ("Введите число N:");
int M = Read_Data ("Введите число M:");
Console.WriteLine($"Сумма чисел в промежутке от {N} до {M} равняется { Sum_Natural_Elements(N,M)}.");
