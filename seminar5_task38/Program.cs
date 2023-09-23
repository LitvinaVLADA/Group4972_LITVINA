// №38 Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


double[] Generator_Arr (int length) //метод для генерации массива вещественных чисел 
{
    double[] arr = new double[length];
    Random rnd = new Random();
    double minValue = 0.00; // Минимальное значение диапазона
    double maxValue = 100.00; // Максимальное значение диапазона

    for (int i = 0; i < length; i++)
    {
        arr[i] = minValue + (rnd.NextDouble() * (maxValue - minValue));  
    }
    return arr;
}

void Print_Arr (double[]arr) //метод для вывода массива в терминал с ограничением в 2 знака после запятой
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i].ToString("F2") + " | ");
        
    }
    Console.WriteLine(arr[arr.Length - 1].ToString("F2") + "]");
}

void Bubble_Sort(double[] array) //сортировка пузырьком
{
    int n = array.Length;
    bool swapped;
    do
    {
        swapped = false;
        for (int i = 1; i < n; i++)
        {
            if (array[i - 1] > array[i])
            {
                // Перемещение эллементов массива
                double temp = array[i - 1];
                array[i - 1] = array[i];
                array[i] = temp;
                swapped = true;
            }
        }
        n--;
    } while (swapped);
}

double Find_Dif (double[] array) //метод для нахождения разницы между эллементами 
{
    double dif = array[array.Length-1]-array[0];
    return dif;
}

double [] final_arr = Generator_Arr (10); //генерация массива
Print_Arr (final_arr);
Bubble_Sort (final_arr);
double result = Find_Dif (final_arr); 
Console.WriteLine ("Разница между максимальным и минимальным элементами массива: "+result.ToString("F2")); //вывод результата с ограничением в 2 знака после запятой


