// Задача 24: Напишите программу, которая 
// принимает на вход число (А) и выдаёт сумму чисел 
// от 1 до А.



int Read_Data(string start) //метод для получения числа
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int Simple_Sum(int num) //метод для суммирования
{
    int sumOfNumber = 0;
    for (int i = 1; i <= num; i++)
    {
        //sumOfNumber = sumOfNumber + i;
        sumOfNumber+=i;
    }
    return sumOfNumber;
}

void Print_Result(string result) //метод для вывода результата
{
    Console.WriteLine(result);
}

int number = Read_Data ("Введите число: ");
int result = Simple_Sum (number);
Print_Result ("Сумма чисел от 1 до "+number+" равняется: "+result); //выводим результат