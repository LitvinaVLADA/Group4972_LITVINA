// Задача 21: Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

int Read_Data (string start) //метод для получения координат
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine()??"0"); 
    return num;
}

double Find_Distance (int x, int y, int z) //метод для вычесления расстояния
{
    double distance = Math.Sqrt(x*x+y*y+z*z);
    return distance;
}

void Print_Result (string msg) //метод для выводы результата
{
    Console.WriteLine(msg);
}


int x1 = Read_Data ("Введите координату x первой точки: "); //получаем последовательно значения для каждой точки
int y1 = Read_Data ("Введите координату y первой точки: ");
int z1 = Read_Data ("Введите координату z первой точки: ");
int x2 = Read_Data ("Введите координату x второй точки: ");
int y2 = Read_Data ("Введите координату y второй точки: ");
int z2 = Read_Data ("Введите координату z второй точки: ");

double distance = Math.Round(Find_Distance ((x1-x2),(y1-y2),(z1-z2)),2); //высчитываем расстояние между точками и округляем его
Print_Result ("Расстояние между точками ({"+x1+"}, {"+y1+"}, {"+z1+"}) и ({"+x2+"}, {"+y2+"}, {"+z2+"}) равно " + distance); //выводим результат


// double Read_Data(string start)
// {
//     Console.WriteLine(start+"1 :");
//     string values1 = Console.ReadLine()??",";

//     string[] valuesArray1 = values1.Split(",");
//     int xA = Convert.ToInt32(valuesArray1[0]);
//     int yA = Convert.ToInt32(valuesArray1[1]);
//     int zA = Convert.ToInt32(valuesArray1[2]);

//     Console.WriteLine(start+"2 :");
//     string values2 = Console.ReadLine()??",";

//     string[] valuesArray2 = values2.Split(",");
//     int xB = Convert.ToInt32(valuesArray2[0]);
//     int yB = Convert.ToInt32(valuesArray2[1]);
//     int zB = Convert.ToInt32(valuesArray2[2]);

//     return DistanceCalculation(xA, yA, zA, xB, yB, zB);
// }

// // Расчёт расстояния
// double DistanceCalculation(int xA, int yA, int zA, int xB, int yB, int zB)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(Math.Abs(xA - xB), 2)
//                     + Math.Pow(Math.Abs(yA - yB), 2)
//                     + Math.Pow(Math.Abs(zA - zB), 2)),2);
// }

// Console.WriteLine(Read_Data("Введите, через запятую, координаты для точки №"));