// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
System.Console.WriteLine();

System.Console.Write("Введите число : ");

int Number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine($"Дано число: {Number}");

if (Number / 100 > 0) 
    System.Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number % 10}");

else System.Console.WriteLine($"У числа {Number} нет третьей цифры");

System.Console.WriteLine();