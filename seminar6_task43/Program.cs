// №43 Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Read_Data(string msg) //метод для получения числа
{
    Console.Write(msg);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}

void Intersection_Point (double k1, double b1, double k2, double b2) //метод для определния точки пересечения
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    // Вывод результатов
    Console.WriteLine($"Точка пересечения: ({x.ToString("F2")}, {y.ToString("F2")})");
}

Console.WriteLine("Последовательно введите значения k1, b1, k2 и b2.");
double k1 =  Read_Data ("k1 = ");
double b1 =  Read_Data ("b1 = ");
double k2 =  Read_Data ("k2 = ");
double b2 =  Read_Data ("b2 = ");
Intersection_Point (k1,b1,k2,b2);