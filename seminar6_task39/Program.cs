// Задача 39: Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, а первый - на 
// последнем и т.д.)

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

int[] Swap_NewArray(int[]arr)
{
    int[] outArr = new int[arr.Length];
    for(int i =0;i<arr.Length;i++)
    {
        outArr[arr.Length-1 - i] = arr[i];
    }
    return outArr;
}

int [] first_arr = Generator_Arr (10); //генерация массива
int [] result_arr = Swap_NewArray (first_arr); //генерация массива путём разворота исходного
Console.WriteLine("Исходный массив");
Print_Arr(first_arr);
Console.WriteLine("Перевернутый массив");
Print_Arr(result_arr);

