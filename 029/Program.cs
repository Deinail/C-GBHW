// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, которые вводит пользователь, и выводит их на экран.

Console.Clear();
System.Console.WriteLine();

Console.WriteLine("");
System.Console.WriteLine("Введите длину массива");
int ArrLength = Convert.ToInt32(Console.ReadLine());
int [] Array = new int [ArrLength];

for (int i = 0; i < Array.Length; i++)
{
    Console.WriteLine("Введите " + (i+1) + " число");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine($"[{string.Join(", ",  Array)}]"); 