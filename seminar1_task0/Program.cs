//Задача №0
//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Console.WriteLine("Введите число: ");
string? InputNumb = Console.ReadLine ( );
if (InputNumb!=null)
{
int numb = int.Parse (InputNumb);
int res = numb * numb ;
Console.WriteLine ("Квадрат числа: "+res);
}

