// 17.Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер четверти плоскости, в которой находится эта 
// точка


Console.WriteLine("Введите координаты точки (X и Y):");
double x = double.Parse(Console.ReadLine()??"0"); //Получаем первое число и записываем его в переменную Х
double y = double.Parse(Console.ReadLine()??"0"); //Получаем второе число и записываем его в переменную У

int quarter = GetQuarter(x, y); //С помощью функции находим в какой четверти лежит наша точка
Console.WriteLine("Точка находится в " + quarter + " четверти плоскости."); //Выводим результат

static int GetQuarter(double x, double y) //Описание функции для нахождения четверти
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else
        {
            return 4;
        }
    }
