// №36 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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



int Sum_Arr_Odd (int[]arr) //метод для суммирования чисел на нечётных позициях массива
{
    int sum_odd = 0;
    for (int i = 1; i < arr.Length; i+=2)
    sum_odd += arr [i];
    return sum_odd;
}

int [] final_arr = Generator_Arr (10); //генерация массива
Print_Arr (final_arr);
int result = Sum_Arr_Odd (final_arr);
Console.WriteLine ("Сумма всех чисел находящихся на нечётных позициях в этом массиве: "+result);

