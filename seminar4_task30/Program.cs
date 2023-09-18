// Задача 30: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и 
// единицами в случайном порядке.

int Read_Data(string start) //метод для получения длины массива
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[] Generator_Arr (int length) //метод для генерации массива
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(0, 2);  //генерация 0 и 1 в цикле
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
int length = Read_Data ("Укажите длину массива: ");
int [] final_arr = Generator_Arr (length);
Print_Arr (final_arr);