// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число: ");
int numb1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число: ");
int numb2 = int.Parse(Console.ReadLine()??"0");

if (numb2%numb1==0)
{
    Console.WriteLine ("Второе число кратно первому");
}
else 
{
    Console.WriteLine ("Второе число не кратно первому");
    Console.WriteLine ("Остаток от деления "+numb2%numb1);
}