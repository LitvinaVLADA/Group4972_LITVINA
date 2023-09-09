// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число: ");
int numb1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число: ");
int numb2 = int.Parse(Console.ReadLine()??"0");

bool test1 = (numb1==numb2*numb2);
bool test2 = (numb2==numb1*numb1);

if (test1) Console.WriteLine ("Первое число квадрат второго!");
if (test2) Console.WriteLine ("Второе число квадрат первого!");
if (!(test1||test2)) Console.WriteLine ("Числа не квадраты друг друга :(");