// Задача 57: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент 
// входных данных.

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

Dictionary<int, int> Frequency(int[,] array) //метод для генерация словаря с повторениями
{
    // Частотный словарь (ключ - элемент массива, значение - количество таких же элементов)
    Dictionary<int, int> freqDict = new Dictionary<int, int>();

    // Перебор элементов массива и проверка наличия значения в словаре
    foreach (int value in array)
    {
        if (freqDict.ContainsKey(value))
            freqDict[value]++;
        else
            freqDict.Add(value, 1);
    }

    return freqDict;
}

void Output_Frequency_Dictionary(Dictionary<int, int> freqDict, string message) //метод для печати словаря
{
    Console.WriteLine();
    Console.WriteLine(message);

    foreach(KeyValuePair<int,int> pair in freqDict)
    {
        Console.WriteLine($"{pair.Key} -> {pair.Value}");
    }
}


int[,] arr_2D = Fill_2D_Array(5,5,20,0);
Print_2D_Array(arr_2D);
Console.WriteLine();
Dictionary<int, int> freqDict = Frequency(arr_2D); 
Output_Frequency_Dictionary (freqDict,"Частотный словарь: ");