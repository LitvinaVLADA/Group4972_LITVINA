// Задача 44: Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int Read_Data(string start) //метод для получения числа
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
void Print_Fibonacci_Numb(int n) // Метод печати чисел Фибоначчи
{
    int first = 0;
    int second = 1;
    int next = 0;

    for (int i = 0; i < n; i++)
    {
        Console.Write(first + " ");
        next = first + second;
        first = second;
        second = next;
    }
}

int numb = Read_Data ("Введите число: ");
Print_Fibonacci_Numb (numb);