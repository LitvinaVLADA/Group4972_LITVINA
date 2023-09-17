// Задача 19: Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно 
// палиндромом.


Console.Write("Введите пятизначное число: "); //получаем число и проверяем пятизначное ли оно
int number = int.Parse(Console.ReadLine()??"0");
if (number < 10000 || number > 99999)
    {
    Console.WriteLine("Число не пятизначное. Попробуйте ещё раз.");
    }
else{
    if (Palindrome_check(number)) //производим проверку на палиндром с нашим числом и выводим результат
        {
        Console.WriteLine("Данное число является палиндромом.");
        }
    else
        {
            Console.WriteLine("Данное число не является палиндромом.");
        }
}


bool Palindrome_check(int number) //метод для проверки на палиндром
{
    Dictionary<int, int> digits = new Dictionary<int, int>();

    // Разбиваем число на отдельные цифры и сохраняем их в словаре
    int digitPosition = 0;
    int digit = number % 10;
    digits.Add(digitPosition, digit);
    digitPosition++;
    number = number / 10;

    // Проверяем, является ли число палиндромом через сверку противостоящих чисел
    for (int i = 0; i < digits.Count / 2; i++)
    {
        if (digits[i] != digits[digitPosition - i - 1])
        {
            return false;
        }
    }

    return true;
}