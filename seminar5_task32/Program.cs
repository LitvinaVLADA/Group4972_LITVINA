// Задача №32
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

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

void Mirror_Array (int[]arr) //метод для перевода эллементов массива в обратное состояние (негативные в позитивные и наоборот)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arr[i]*=-1;
    }
}


int [] final_arr = Generator_Arr (10,-10,10); //генерация массива

Console.WriteLine ("Отражением для массива: ");
Print_Arr (final_arr);
Console.WriteLine ("Будет: ");
Mirror_Array (final_arr);
Print_Arr (final_arr);