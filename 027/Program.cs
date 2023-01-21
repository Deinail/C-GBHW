//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int Summ = 0;

while ( a > 0)
{
    Summ = Summ + (a % 10);
    a = a / 10;
}
System.Console.WriteLine("Сумма чисел равна " + Summ);