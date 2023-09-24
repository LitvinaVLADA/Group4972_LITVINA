// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] Generator_Arr (int length) //метод для генерации массива
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(1, 20);  
    }
    return arr;
}

void Print_Arr (int[]arr) //метод для вывода массива в терминал
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int [] Copy_Arr (int [] arr)
{
    int[]copy_arr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copy_arr[i] = arr[i];  
    }
    return copy_arr;
}

int [] first_arr = Generator_Arr (10); //генерация массива
int [] arr_copy = Copy_Arr (first_arr); //генерация массива путём копирования
Console.WriteLine("Исходный массив");
Print_Arr(first_arr);
Console.WriteLine("Скопированный массив");
Print_Arr(arr_copy);