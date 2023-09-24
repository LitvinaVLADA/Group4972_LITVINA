// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.

double Read_Data(string start) //метод для получения данных
{
    Console.Write(start);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}

bool Is_Trianglable (double a, double b, double c) //метод для проверки на треугольник
{
    return !(a+b <= c || b+c <= a || a+c <= b);
}

double side1 = Read_Data ("Введите первое число: ");
double side2 = Read_Data ("Введите второе число: ");
double side3 = Read_Data ("Введите третье число: ");

Console.WriteLine (Is_Trianglable(side1,side2,side3)? "Треугольник со сторонами такой длины МОЖЕТ существовать." : "Треугольник со сторонами такой длины НЕ МОЖЕТ существовать.");