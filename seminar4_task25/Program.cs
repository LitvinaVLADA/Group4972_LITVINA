// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B.

int Read_Data(string start) //метод для получения числа
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double Degree_Calculator (int A, int B) //метод для возведения в натуральную степень
{
    double degree_res = 1;
    if (B>0) //цикл для положительной степени
    {
        for (int i = 1; i <= B; i++)
        {
            degree_res *=A;
        }
    }
    else //цикл для отрицательной степени
    {
        for (int i = 1; i <= Math.Abs(B); i++)
        {
            degree_res /=A;
        }
    }
    return degree_res;
}

void Print_Result(string result) //метод для вывода результата
{
    Console.WriteLine(result);
}

int number_A = Read_Data ("Введите число которое будем возводить в степень: ");
int number_B = Read_Data ("Введите степень: ");
double result = Degree_Calculator(number_A, number_B);
Print_Result ("Результатом возведения числа "+number_A+" в степень "+number_B+" будет: "+result); //выводим результат