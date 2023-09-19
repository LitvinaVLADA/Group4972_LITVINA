// Задача №33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.



int Read_Data(string start) //метод для получения искомого числа
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[] Generator_Arr (int length, int lowborder, int highborder) //метод для генерации массива
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(lowborder, highborder+1);  
    }
    return arr;
}

string Check_Array(int[] array, int num) //метод для поиска числа в массиве
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num)
            return $"Число {num} есть в массиве, его индекс {i}";
    return $"Числа {num} нет в массиве";
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

int [] final_arr = Generator_Arr (20,-50,50); //генерация массива
Print_Arr (final_arr);
int num = Read_Data("Введите число для поиска: ");
Console.WriteLine (Check_Array(final_arr,num)); //вывод результата

