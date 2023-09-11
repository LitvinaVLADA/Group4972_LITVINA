// Задача 21: Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D 
// пространстве


Console.WriteLine("Введите координаты первой точки (x1, y1):");
        double x1 = double.Parse(Console.ReadLine()??"0");
        double y1 = double.Parse(Console.ReadLine()??"0");

        Console.WriteLine("Введите координаты второй точки (x2, y2):");
        double x2 = double.Parse(Console.ReadLine()??"0");
        double y2 = double.Parse(Console.ReadLine()??"0");

        double distance = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)),2);

        Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2}) равно {distance}");