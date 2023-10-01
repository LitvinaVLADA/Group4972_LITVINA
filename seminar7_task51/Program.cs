// Задача 51: Задайте двумерный массив. Найдите сумму 
// элементов, находящихся на главной диагонали (с индексами 
// (0,0); (1;1) и т.д.

int Read_Data(string start) //метод для получения размера массива
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
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

int Main_Diagonal_Sum(int[,] array) //метод для суммирования чисел главной диагонали
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;
}


int row = Read_Data("Введите количество строк: ");
int column = Read_Data("Введите количество столбцов: ");
int[,] arr_2D = Fill_2D_Array(row,column,10,0);
Print_2D_Array(arr_2D);
Console.WriteLine();
Console.WriteLine("Сумма эл-тов главной диагонали: " + Main_Diagonal_Sum(arr_2D));