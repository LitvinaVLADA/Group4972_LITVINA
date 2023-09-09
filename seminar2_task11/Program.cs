// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

System.Random NumbGENER = new System.Random ();
int numb = NumbGENER.Next (100,1000);
Console.WriteLine(numb);

int firstDIG = numb/100;
int lastDIG = numb%10;

int result = firstDIG*10+lastDIG;
Console.WriteLine (result);
