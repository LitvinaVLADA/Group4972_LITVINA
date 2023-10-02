// Задача 62: Заполните спирально массив 4 на 4.

void Spiral_Fill(int[,] array) //метод для спирального заполнения массива
{
    int n = array.GetLength(0); // размер массива
    int value = 1; // начальное значение для заполнения

    int startRow = 0; // индекс начальной строки
    int endRow = n - 1; // индекс конечной строки
    int startColumn = 0; // индекс начального столбца
    int endColumn = n - 1; // индекс конечного столбца

    while (value <= n * n)
    {
        // заполняем верхнюю строку слева на право
        for (int i = startColumn; i <= endColumn; i++)
        {
            array[startRow, i] = value;
            value++;
        }
        startRow++;

        // заполняем правый столбец сверху вниз
        for (int i = startRow; i <= endRow; i++)
        {
            array[i, endColumn] = value;
            value++;
        }
        endColumn--;

        // заполняем нижнюю строку справа налево
        for (int i = endColumn; i >= startColumn; i--)
        {
            array[endRow, i] = value;
            value++;
        }
        endRow--;

        // заполняем левый столбец снизу вверх
        for (int i = endRow; i >= startRow; i--)
        {
            array[i, startColumn] = value;
            value++;
        }
        startColumn++;
    }
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

int[,] array = new int[4, 4];
Spiral_Fill(array);
Print_2D_Array (array);