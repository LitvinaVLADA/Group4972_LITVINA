// Задача 67. Программа принимает на вход число N и возвращает сумму цифр в числе.

int Read_Data (string start) //метод для получения числа
{
    Console.WriteLine(start);
    int num = int.Parse(Console.ReadLine()??"0"); 
    return num;
}

int Digit_Sum(int num)
{
    if(num > 0)
    {
    return  Digit_Sum(num/10)+num%10;
    } 
    else return 0;
}

int N = Read_Data ("Введите число N:");
Console.WriteLine($"Сумма цифр в числе {N} равняется { Digit_Sum(N)}.");
