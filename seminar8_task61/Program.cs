// Задача 61: Вывести первые N строк треугольника 
// Паскаля. Сделать вывод в виде равнобедренного 
// треугольника

int Read_Data(string start) //метод для получения количества строк
{
    Console.Write(start);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//n!/k!*(n-k)!
long Factoreal(int n)
{
    long res = 1;
    for(int i=1;i<=n;i++)
    {
        res=res*i;
    }
    return res;
}

void Print_Pascal_Triangle(int nRow) //метод для вывода треугольника Паскаля на экран где каждая строчка будет печататься разным цветом
{
    ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for(int i=0;i<nRow;i++)
    {
        Console.ForegroundColor = colors[new System.Random().Next(0,16)];
        for(int k =0;k<nRow-i;k++)
        {
            Console.Write(" ");
        }

        for(int j =0; j<=i;j++)
        {
           Console.Write(" ");
           
           Console.Write(Factoreal(i)/(Factoreal(j)*Factoreal(i-j)));
           
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}

int countRow = Read_Data("Введите количество строк треугольника Паскаля: ");
Print_Pascal_Triangle(countRow);