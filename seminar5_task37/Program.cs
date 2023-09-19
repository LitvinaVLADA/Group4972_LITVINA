// Задача №37
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

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

void Print_Arr (int[]arr) //метод для вывода массива в терминал
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] Convert_Array (int[]arr) //метод для вычисления произведений пар чисел и создание нового массива
{
    int [] out_array = new int [arr.Length/2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        out_array[i]=arr[i]*arr[arr.Length-1-i];
    }

    return out_array;
}


int [] basik_arr = Generator_Arr (123,-100,100); //генерация массива
Console.Write ("ИЗНАЧАЛЬНЫЙ МАССИВ: ");
Print_Arr (basik_arr);
int [] final_arr = Convert_Array (basik_arr); //вывод просчитанного массива
Console.Write ("ФИНАЛЬНЫЙ МАССИВ: ");
Print_Arr (final_arr);