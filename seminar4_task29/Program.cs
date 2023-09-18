// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int Read_Data(string start) //метод для получения длины массива
// {
//     Console.Write(start);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// int[] Generator_Arr (int length) //метод для генерации массива
// {
//     int[] arr = new int[length];
//     Random rnd = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = rnd.Next(0, 100);  //генерация случайных чисел в цикле
//     }
//     return arr;
// }


// void Print_Arr (int[]arr) //метод для вывода массива в терминал
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
        
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }
// int length = Read_Data ("Укажите длину массива: ");
// int [] final_arr = Generator_Arr (length);
// Print_Arr (final_arr);

// (задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов

int Read_Data(string start) //метод для получения длины массива
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[] Generator_Arr (int length, int min, int max) //метод для генерации массива с заданным диапазоном значений
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max);  //генерация случайных чисел в цикле
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
int diap_min = Read_Data ("Использовать диапазон чисел с "); //заведение начала диапазона
int diap_max = Read_Data ("по "); //заведение конца диапазона
int [] final_arr = Generator_Arr (length,diap_min,diap_max);
Print_Arr (final_arr);