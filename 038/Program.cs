// Задача 38: Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.Clear();
System.Console.WriteLine();

Console.WriteLine("");
int ArrLength = new Random().Next(4,10);
int [] Array = new int [ArrLength];
int Difference = 0;

for (int i = 0; i < Array.Length; i++)
    Array[i] = new Random().Next(99,1000);

Difference = Array.Max() - Array.Min();

System.Console.WriteLine($"[{string.Join(", ",  Array)}]"); 
System.Console.WriteLine("Разница между минимальным и максимальным значениями массива равна " + Difference);
System.Console.WriteLine();