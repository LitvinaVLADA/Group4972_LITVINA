// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.


int Read_Data(string start) //метод для получения размера массива
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void Print_2D_Array(int[,] matrix) //метод для печати двумерного массива
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

int [,] Fill_2D_Array (int countRow, int countColumn, int topBorder, int downBorder) //метод для рандомной генерации двумерного массива
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = rnd.Next(downBorder,topBorder);
        }
    }

    return array2D;
}

void Print_Arr (double[]arr) //метод для вывода массива в терминал с ограничением в 2 знака после запятой
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i].ToString("F2") + "\t"); 
    }
    Console.WriteLine(arr[arr.Length - 1].ToString("F2"));
    Console.ResetColor();
}

double [] Find_Average_In_Columns (int [,] matrix)
{ 
    double[] result = new double[matrix.GetLength(1)];
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        result[j] = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
        result[j] +=matrix[i,j];
        }
        result[j]/=matrix.GetLength(0);
    }
    return result;
}

int row = Read_Data("Введите количество строк: ");
int column = Read_Data("Введите количество столбцов: ");
int[,] arr_2D = Fill_2D_Array(row,column,100,10);
Print_2D_Array(arr_2D);
Console.WriteLine();
double[] arr_result = Find_Average_In_Columns (arr_2D);
Print_Arr(arr_result);