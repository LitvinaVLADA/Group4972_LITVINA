// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// * Сделать вариант для числа длиной до 10 цифр не используя char или string

void Variant1()

{
    Console.WriteLine ("Перый способ:");
    
    Console.Write ("Введите число: ");
    int numb = int.Parse(Console.ReadLine()??"0"); //Получаем число и записываем его в переменную

    char[] digitChar = numb.ToString().ToCharArray(); //переводм наше число в список символов, где у каждой цифры будет свой порядковый номер
    if (numb>100)
    {
        Console.WriteLine(digitChar[2]);//выводим третюю цифру числа
    }
    else 
    {
        Console.WriteLine("Третьей цифры нет :("); //прописываем что выводить в случае отсутствия 3й цифры
    }
}

void Variant2()

{
    Console.WriteLine ("Второй способ:");
    
    Console.Write ("Введите число: ");
    int numb = int.Parse(Console.ReadLine()??"0"); //Получаем число и записываем его в переменную

    if (numb<100) //проверяем есть ли третья цифра
    {
        Console.WriteLine("Третьей цифры нет :(");
    }
    else 
    {
        if (numb<1000) //создаём формулы для нахождения третьей цифры, подходящие для разных чисел (5-ти значных, 7-ми значных и т.п.)
        Console.WriteLine (numb%10);
        else 
        {
            if (numb<10000)
            Console.WriteLine ((numb%100-numb%10)/10);
            else
            {
                if (numb<100000)
                Console.WriteLine ((numb%1000-numb%100)/100);
                else
                {
                    if (numb<1000000)
                    Console.WriteLine ((numb%10000-numb%1000)/1000);
                    else
                    {
                        if (numb<10000000)
                        Console.WriteLine ((numb%100000-numb%10000)/10000);
                        else
                        {
                            if (numb<100000000)
                            Console.WriteLine ((numb%1000000-numb%100000)/100000);
                            else
                            {
                               if (numb<1000000000)
                                Console.WriteLine ((numb%10000000-numb%1000000)/1000000);
                                
                            }
                        }
                    }
                }
            }
        }
    }

}

Variant1(); //выводим методы
Variant2();