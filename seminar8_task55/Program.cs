// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для 
// пользователя.

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
void Transponation_Matrix(int[,] matrix) //метод для переворота массива и вывод результата
{
    if(matrix.GetLength(0) == matrix.GetLength(1)){
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[j,i];
            matrix[j,i] = matrix[i,j];
            matrix[i,j] = temp;
        }
    }
    Print_2D_Array(matrix);
    } else {
        Console.WriteLine("Этот массив нельзя перевернуть");
    }
}

int[,] arr_2D = Fill_2D_Array(7,7,100,10);
Print_2D_Array(arr_2D);
Console.WriteLine();
Transponation_Matrix (arr_2D);

