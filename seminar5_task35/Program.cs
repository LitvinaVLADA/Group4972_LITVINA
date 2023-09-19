// Задача №35
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


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

int Count_Elem (int[]arr) //метод для просчёта количества элементов массива, значения которых лежат в заданном отрезке
{
    int count = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if ((arr[i]>=10)&&(arr[i]<=99))
        {
            count ++;
        }
    }
    return count;
}

int [] final_arr = Generator_Arr (123,-500,500); //генерация массива
Print_Arr (final_arr);
int result = Count_Elem (final_arr); //просчёт количества элементов массива, значения которых лежат в отрезке [10,99]
Console.WriteLine ("Числа из отрезка [10,99] встречаются в массиве: "+result+" раз.");
