//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень числа");
int b = Convert.ToInt32(Console.ReadLine());
int Result = a;

for ( int i = 1; i < b; i++ ) 
{
    Result = Result * a;
}
System.Console.WriteLine(a + " в степени " + b + " равно " + Result);