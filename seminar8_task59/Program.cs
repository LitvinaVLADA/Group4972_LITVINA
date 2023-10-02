// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на 
// пересечении которых расположен наименьший элемент 
// массива.

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

(int smallestValue,  int colIndex, int rowIndex) Find_Min_Element(int[,] matrix) //метод для поиска наименьшего элемента в массиве и его индекса
{
    int smallestValue = int.MaxValue;
    int rowIndex = -1;
    int colIndex = -1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < smallestValue)
            {
                smallestValue = matrix[i, j];
                rowIndex = i;
                colIndex = j;
            }
        }
    }
    return (smallestValue, rowIndex, colIndex);
}


int[,] Remove_Row_And_Column(int[,] matrix, int rowIndex, int colIndex) //метод для удаления строки и столбца из двумерного массива
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    int[,] resultMatrix = new int[rowCount - 1, colCount - 1];

    for (int i = 0, newRow = 0; i < rowCount; i++)
    {
        if (i == rowIndex) continue; // Если индекс строки равен индексу минимального, его пропускаем

        for (int j = 0, newCol = 0; j < colCount; j++)
        {
            if (j == colIndex) continue; // Если индекс столбца равен индексу минимального, его пропускаем

            resultMatrix[newRow, newCol] = matrix[i, j];
            newCol++;
        }
        newRow++;
    }

    return resultMatrix;
}

int[,] arr_2D = Fill_2D_Array(5,5,200,10);
Print_2D_Array(arr_2D);
Console.WriteLine();
(int smallestValue, int colIndex, int rowIndex) min = Find_Min_Element (arr_2D);
Console.WriteLine ($"Наименьший элемент: {min.smallestValue} позиция [{min.rowIndex},{min.colIndex}]");
Console.WriteLine();
int[,] arr_2D_result = Remove_Row_And_Column (arr_2D,min.colIndex,min.rowIndex);
Console.WriteLine("Итоговый массив:");
Print_2D_Array(arr_2D_result);

