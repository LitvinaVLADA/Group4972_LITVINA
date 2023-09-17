// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.

int Read_Data(string start) //метод для получения числа
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
int Number_Length(int num) //метод для определения количества цифр в числе
{
    int length = 0;
    while (num > 0)
    {
        num /= 10;
        length++;
    }
    return length;
}

void Print_Result(string result) //метод для вывода результата
{
    Console.WriteLine(result);
}

int number = Read_Data ("Введите число: ");
int result = Number_Length (number);
Print_Result ("Количество цифр в числе "+number+": "+result); //выводим результат