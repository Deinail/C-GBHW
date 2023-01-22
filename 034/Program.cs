// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
System.Console.WriteLine();

Console.WriteLine("");
int ArrLength = new Random().Next(4,10);
int [] Array = new int [ArrLength];
int Counter = 0;

for (int i = 0; i < Array.Length; i++)
{
Array[i] = new Random().Next(99,1000);
    if (Array[i] % 2 < 1)
        Counter++;
}

System.Console.WriteLine($"[{string.Join(", ",  Array)}]"); 
System.Console.WriteLine("В массиве " + Counter + " положительных числа");