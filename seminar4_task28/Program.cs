// Задача 28: Напишите программу, которая 
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.

int Read_Data(string start) //метод для получения числа
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long Simple_Mult(int num) //метод для умножения
{
    long fact = 1;

    for (int i = 2; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

void Print_Result(string result) //метод для вывода результата
{
    Console.WriteLine(result);
}

int number = Read_Data ("Введите число: ");
long result = Simple_Mult(number);
Print_Result ("При умножении чисел от 1 до "+number+" получается: "+result); //выводим результат