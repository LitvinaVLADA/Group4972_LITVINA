// №34 Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// (со звездочкой) Отсортировать массив методом пузырька


int[] Generator_Arr (int length) //метод для генерации массива
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(100, 1000);  
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

int Even_Test (int[]arr) //метод для проверки чисел на чётность
{
    int count_even = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i]%2 == 0) //если остаток от деления на 2 равен 0 значит число чётное
        {
            count_even = count_even+1;
        }
    }
    return count_even;
}  

void Bubble_Sort(int[] array) //сортировка пузырьком
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
                int temp = array[i - 1];
                array[i - 1] = array[i];
                array[i] = temp;
                swapped = true;
            }
        }
        n--;
    } while (swapped);
}


int [] final_arr = Generator_Arr (6); //генерация массива
Print_Arr (final_arr);
int result = Even_Test (final_arr);
Console.WriteLine ("В данном массиве количество чётных чисел: "+result);
Console.Write ("Отсортированный массив: ");
Bubble_Sort (final_arr);
Print_Arr (final_arr);
