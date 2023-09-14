// Задача 18: Напишите программу, которая по 
// заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой 
// четверти (x и y).


int Read_Quarter (string start) //метод для получения номера четверти
{
    Console.WriteLine(start);
    int quarter = int.Parse(Console.ReadLine()??"0"); 
    return quarter;
}


string Data_Ind (int quarter) //метод для определения возможный дапозон координат
{
        switch (quarter) 
        {
        case 1: return "Возможные координаты точек в четверти 1: (X > 0 ; Y > 0)";
        case 2: return "Возможные координаты точек в четверти 2:(X < 0 ; Y > 0)";
        case 3: return "Возможные координаты точек в четверти 3:(X < 0 ; Y < 0)";
        case 4: return "Возможные координаты точек в четверти 4:(X > 0 ; Y < 0)";
        default: return "Нет такой четверти. Повторите попытку.";
        }
}


int quarter = Read_Quarter("Введите номер четверти где находится точка:");
Console.WriteLine(Data_Ind (quarter));

