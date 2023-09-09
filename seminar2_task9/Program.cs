// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

System.Random NumbGENER = new System.Random ();
int numb = NumbGENER.Next (10,100);
Console.WriteLine(numb);

int FirstDig = numb/10;
int SecondDig = numb%10;

if(FirstDig>SecondDig)
{
    Console.WriteLine(FirstDig);
}
else
{
    Console.WriteLine(SecondDig);
}