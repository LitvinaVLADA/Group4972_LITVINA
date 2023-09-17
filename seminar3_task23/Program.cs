// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N

int Read_Data (string start) //метод для получения числа N
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine()??"0"); 
    return num;
}

string Build_Line (int num, int pow) //метод для вывода строки с числами с учетом куба
{
    string result = "";
    for (int i = 1; i <= num; i++)
    {
        result = result + Math.Pow(i,pow)+" ";
    }
    return result;
}


void Print_Result (string msg) //метод для вывода результата
{
    Console.WriteLine(msg);
}

int n = Read_Data ("Введите число: ");
Print_Result (Build_Line (n, 1)); //первая строка где перечисляются числа
Print_Result (Build_Line (n, 3)); //вторая строка где указываются кубы чисел