// Задача 49: Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их 
// квадраты

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
void Array_Square_Evens(int[,] array) //метод для возведения в квадрат элементов с чётными индексами
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}

void Print_2D_Array_Colour(int[,] array) //метод для печати двумерного массива с выделением цветом элементов с чётными индексами
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i % 2 == 0 && j % 2 == 0) //проверяем, оба ли индекса чётные
                {
                    Console.ForegroundColor = ConsoleColor.Red; //печатаем элемент красным цветом
                }
                else
                {
                    Console.ResetColor(); //используем стандартный цвет
                }

                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ResetColor();
    }

int row = Read_Data("Введите количество строк: ");
int column = Read_Data("Введите количество столбцов: ");
int[,] arr_2D = Fill_2D_Array(row,column,100,10);
Print_2D_Array(arr_2D);
Console.WriteLine();
Array_Square_Evens (arr_2D);
Print_2D_Array_Colour(arr_2D);
