// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int Read_Data (string start) //метод для получения числа
{
    Console.WriteLine(start);
    int num = int.Parse(Console.ReadLine()??"0"); 
    return num;
}

int Ackermann(int m, int n) //метод для вычисления фунции Аккермана
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}

int N = Read_Data ("Введите число N:");
int M = Read_Data ("Введите число M:");
Console.WriteLine($"Функция Аккермана для чисел {N} и {M} равняется { Ackermann(N,M)}.");