// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

int Read_Data(string start) //метод для получения размера массива
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int [,] Fill_2D_Array_Index_Sum (int countRow, int countColumn) //метод для генерации двумерного массива c суммами индексов
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
       { for (int j = 0; j < countColumn; j++)
            array2D[i, j] = i + j;
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

int row = Read_Data("Введите количество строк: ");
int column = Read_Data("Введите количество столбцов: ");
int[,] arr_2D_sum_index = Fill_2D_Array_Index_Sum(row,column);
Print_2D_Array(arr_2D_sum_index);