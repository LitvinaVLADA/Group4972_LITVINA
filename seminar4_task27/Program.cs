// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.


int Read_Data(string start) //метод для получения числа
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int Super_Sum (int num) //метод для суммирования цифр в числе
{
    int sum = 0;

    while (num > 0)
    {
        int digit = num % 10; // получаем последнюю цифру числа
        sum += digit; // добавляем цифру к сумме
        num /= 10; // удаляем последнюю цифру числа
    }

    return sum;
}


void Print_Result(string result) //метод для вывода результата
{
    Console.WriteLine(result);
}

int number = Read_Data ("Введите число: ");
int result = Super_Sum (number);
Print_Result ("Сумма всех цифр в числе "+number+" равняется "+result);