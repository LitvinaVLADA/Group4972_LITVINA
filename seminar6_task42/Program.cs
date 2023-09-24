// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.

int Read_Data(string start) //метод для получения числа
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string Dec_To_Bin(int num) //метод для конвертации десятичного числа в двоичное в виде строки
{
    string line ="";
    while(num>0)
    {
        line = num%2+line;
        num=num/2;
    }
    return line;
}

int numb = Read_Data ("Введите число: ");
Console.WriteLine("Двоичное представление числа "+numb+" : "+Dec_To_Bin(numb));
