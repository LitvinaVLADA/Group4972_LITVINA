// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int Read_Data(string start) //метод для получения числа
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
int Count_Positive_Numbers(int count) //метод дл введения пользователем чисел и одновременной проверки на >0
{  
    int positiveCount = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int number = int.Parse(Console.ReadLine()?? "0");
        if (number > 0)
        {
            positiveCount++;
        }
    }
    
    return positiveCount;
}

int count = Read_Data("Введите количество чисел: ");
int result = Count_Positive_Numbers (count);
Console.WriteLine ("Количество чисел больше 0: "+result);