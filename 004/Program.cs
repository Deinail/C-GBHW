//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите первое число");

int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");

int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье число");

int c = Convert.ToInt32(Console.ReadLine());

if (a < b )
{
    if (b < c )
        System.Console.WriteLine("Число " + c + " наибольшее ");
    else
        System.Console.WriteLine("Число " + b + " наибольшее ");
}

else
{
    if (a < c )
        System.Console.WriteLine("Число " + c + " наибольшее ");
    else
        System.Console.WriteLine("Число " + a + " наибольшее ");
}