// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.

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

(int,int) Сalculator_Neg_Pos_Sum (int[]arr) //метод для суммирования эллементов массива с проверкой на +/-
{
    int Positiv_Sum = 0;
    int Negative_Sum = 0;

    for (int i = 0 ; i < arr.Length - 1; i++)
    {
        if (arr[i]>0) //проверка позитивное число и негативное
        Positiv_Sum += arr[i];
        else 
        Negative_Sum += arr[i];
    }
    return (Positiv_Sum,Negative_Sum); //вывод двух чисел из метода
}

int [] final_arr = Generator_Arr (12,-9,9); //генерация массива
Print_Arr (final_arr);
(int pos, int neg) sum = Сalculator_Neg_Pos_Sum (final_arr); //вывод сразу двух результатов из метода
Console.WriteLine ("Сумма чисел >0: "+sum.pos+", Сумма чисел <0: "+sum.neg);