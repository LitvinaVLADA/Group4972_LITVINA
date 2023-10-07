// Задача 69. Напишите программу, которая будет принимать 2 числа A и B. 
// Возведёт A в степень B с помощью рекурсии.

int Read_Data (string start) //метод для получения числа
{
    Console.WriteLine(start);
    int num = int.Parse(Console.ReadLine()??"0"); 
    return num;
}

long Exponentiation(int a,int b)
{
    if(b==2)return a*a;
    if(b==1)return a;

    if(b%2==0)
    {
       return Exponentiation(a,b/2)*Exponentiation(a,b/2);
    }
    else
    {
       return Exponentiation(a,b/2)*Exponentiation(a,b/2+1);
    }
}

int A = Read_Data ("Введите число:");
int B = Read_Data ("Введите степень:");
Console.WriteLine($"Число {A} в степени {B} = {Exponentiation(A, B)}");