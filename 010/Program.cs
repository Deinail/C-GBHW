// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

System.Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(" Второй цифрой числа " + a + " будет " + (a / 10 % 10));