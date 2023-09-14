// 17.Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер четверти плоскости, в которой находится эта 
// точка

int Read_Data (string start) //метод для получения координат
{
    Console.WriteLine(start);
    int num = int.Parse(Console.ReadLine()??"0"); 
    return num;
}

int GetQuarter(int x, int y) //метод для нахождения четверти
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    else return 4;
}

void Print_Result (string msg) //метод для выводы результата
{
    Console.WriteLine(msg);
}



int x = Read_Data("Введите координату точки X:");//Получаем первое число и записываем его в переменную Х
int y = Read_Data("Введите координату точки Y:");//Получаем второе число и записываем его в переменную У

int result = GetQuarter(x,y); //определяем четверть

Print_Result ("Точка находится в "+result+" четверти плоскости"); //выводи результат т.е. номер четверти

