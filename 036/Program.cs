// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
System.Console.WriteLine();

Console.WriteLine("");
int ArrLength = new Random().Next(4,10);
int [] Array = new int [ArrLength];
int Summ = 0;

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(99,1000);
        if ( i % 2 >= 1 )
            Summ = Summ + Array[i];
}
System.Console.WriteLine($"[{string.Join(", ",  Array)}]"); 
System.Console.WriteLine("Сумма чисел на нечётных позициях массива равна " + Summ);