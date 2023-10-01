// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int Read_Data(string start) //метод для получения размера массива
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double [,] Fill_2D_Array (int countRow, int countColumn, double topBorder, double downBorder) //метод для рандомной генерации двумерного массива вещественнх чисел
{
    System.Random rnd = new System.Random();
    double[,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            double value = rnd.NextDouble() * (topBorder - downBorder) + downBorder;
            array2D[i, j] = Math.Round(value, 2);
        }
    }

    return array2D;
}

void Print_2D_Array(double[,] matrix) //метод для печати двумерного массива
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" \t");
        }
        Console.WriteLine();
    }
}


int row = Read_Data("Введите количество строк: ");
int column = Read_Data("Введите количество столбцов: ");
double[,] arr_2D = Fill_2D_Array(row,column,10,0);
Print_2D_Array(arr_2D);