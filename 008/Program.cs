// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

int i = 1;

System.Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Чётные числа из диапазона от 1 до {a}:");

while (i < a)
{
    i++;
    if (i % 2 == 0)
    System.Console.Write($"{i} ");
}
