// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.


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

int[,] Matrix_Multiplication(int[,] matrix1, int[,] matrix2)  //метод для перемножения матриц
{
    // Проверяем, что количество столбцов первой матрицы равно количеству строк второй матрицы
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        throw new ArgumentException("Невозможно умножить матрицы: неправильные размеры");
    }

    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int cols2 = matrix2.GetLength(1);

    int[,] result = new int[rows1, cols2];

    // Вычисляем произведение матриц
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            for (int k = 0; k < cols1; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}

int[,] first_arr_2D = Fill_2D_Array(3,3,10,0);
int[,] second_arr_2D = Fill_2D_Array(3,3,10,0);
Console.WriteLine("Первый массив");
Print_2D_Array(first_arr_2D);
Console.WriteLine();
Console.WriteLine("Второй массив");
Print_2D_Array(second_arr_2D);
Console.WriteLine();
Console.WriteLine("Результат");
int[,] result_arr_2D = Matrix_Multiplication (first_arr_2D,second_arr_2D);
Print_2D_Array(result_arr_2D);


