// Задача 20: Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D 
// пространстве

int Read_Data (string start) //метод для получения координат
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine()??"0"); 
    return num;
}

double Find_Distance (int x, int y) //метод для вычесления расстояния
{
    double distance = Math.Sqrt(x*x+y*y);
    return distance;
}

void Print_Result (string msg) //метод для выводы результата
{
    Console.WriteLine(msg);
}


int x1 = Read_Data ("Введите координату x первой точки: "); //получаем последовательно значения для каждой точки
int y1 = Read_Data ("Введите координату y первой точки: ");
int x2 = Read_Data ("Введите координату x второй точки: ");
int y2 = Read_Data ("Введите координату y второй точки: ");

double distance = Math.Round(Find_Distance ((x1-x2),(y1-y2)),2); //высчитываем расстояние между точками и округляем его
Print_Result ("Расстояние между точками ({"+x1+"}, {"+y1+"}) и ({"+x2+"}, {"+y2+"}) равно " + distance); //выводим результат
