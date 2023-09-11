// Задача 18: Напишите программу, которая по 
// заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой 
// четверти (x и y).

Console.WriteLine("Введите номер четверти где находится точка:");
int quarter = Convert.ToInt32(Console.ReadLine()??"0");
int xMin, xMax, yMin, yMax;

switch (quarter)
    {
        case 1:
                xMin = 0;
                xMax = int.MaxValue;
                yMin = 0;
                yMax = int.MaxValue;
                break;
        case 2:
                xMin = int.MinValue;
                xMax = 0;
                yMin = 0;
                yMax = int.MaxValue;
                break;
        case 3:
                xMin = int.MinValue;
                xMax = 0;
                yMin = int.MinValue;
                yMax = 0;
                break;
        case 4:
                xMin = 0;
                xMax = int.MaxValue;
                yMin = int.MinValue;
                yMax = 0;
                break;
        default:
                Console.WriteLine("Неверный номер четверти");
                return;
    }

Console.WriteLine($"Диапазон координат точек в четверти {quarter}:");
Console.WriteLine($"x: от {xMin} до {xMax}");
Console.WriteLine($"y: от {yMin} до {yMax}");
