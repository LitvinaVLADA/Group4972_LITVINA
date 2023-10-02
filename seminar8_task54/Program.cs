// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

void Bubble_Sort_Row(int[,] matrix) //сортировка пузырьком
{
    int column = matrix.GetLength(1);
    int row = matrix.GetLength(0);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column - 1; j++)
        {
            for (int k = 0; k < column - j - 1; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}

int[,] arr_2D = Fill_2D_Array(5,5,100,10);
Console.WriteLine("Исходный массив");
Print_2D_Array(arr_2D);
Console.WriteLine();
Console.WriteLine("Массив с отсортированными строками");
Bubble_Sort_Row (arr_2D);
Print_2D_Array(arr_2D);
