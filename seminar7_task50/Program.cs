// Задача 50: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.

int Read_Data(string start) //метод для получения индекса искомого элемента
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

void Print_2D_Array_Colour(int[,] array, int row, int col) //метод для печати двумерного массива с выделением цветом искомого элемента
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == row-1 && j == col-1) //проверяем искомый ли это элемент
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
        if (array.GetLength(0)<row||array.GetLength(1)<col)
        {
            Console.WriteLine("Элемента с такими индексами в данном массиве нет.");
        }
    }

int find_row = Read_Data("Введите номер строки искомого элемента: ");
int find_column = Read_Data("Введите номер столбца искомого элемента: ");
int[,] arr_2D = Fill_2D_Array(5,10,100,10);
Print_2D_Array_Colour(arr_2D,find_row,find_column);
