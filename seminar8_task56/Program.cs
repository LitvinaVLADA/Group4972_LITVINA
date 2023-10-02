// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

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

 int Find_Row_With_Min_Sum(int[,] matrix) //метод для описка строки с наименьшей суммой элемнетов
{
    int numRows = matrix.GetLength(0); 
    int numCols = matrix.GetLength(1); 

    int minSum = int.MaxValue; // переменная для хранения наименьшей суммы
    int minRowIndex = -1; // переменная для хранения индекса строки с наименьшей суммой

    // перебираем каждую строку и находим сумму ее элементов
    for (int i = 0; i < numRows; i++)
    {
        int rowSum = 0; 

        
        for (int j = 0; j < numCols; j++)
        {
            rowSum += matrix[i, j];
        }

        // если сумма текущей строки меньше минимальной суммы,
        // обновляем минимальную сумму и индекс строки с наименьшей суммой
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minRowIndex = i;
        }
    }
    return minRowIndex;
}

int[,] arr_2D = Fill_2D_Array(5,5,100,10);
Print_2D_Array(arr_2D);
Console.WriteLine();

int minRowIndex = Find_Row_With_Min_Sum(arr_2D);
Console.WriteLine("Строка с наименьшей суммой элементов: "+(minRowIndex+1));
