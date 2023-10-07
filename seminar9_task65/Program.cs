// Задача 65. Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N. 

int Read_Data (string start) //метод для получения числа
{
    Console.WriteLine(start);
    int num = int.Parse(Console.ReadLine()??"0"); 
    return num;
}

string Search_Natural_Elements (int m, int n) //метод для вывода всех натруальных чисел в промежутке
{
    return n >= m ? $"{m} " + Search_Natural_Elements(m + 1, n) : "";
}

int N = Read_Data ("Введите число N:");
int M = Read_Data ("Введите число M:");
Console.WriteLine((M>N)?Search_Natural_Elements(N, M):Search_Natural_Elements(M, N));