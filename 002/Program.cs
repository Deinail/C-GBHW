//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine();

int a = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());

if (a<b)
    System.Console.WriteLine("Число " + b + " больше числа " + a);

else 
    if (a<b)
    System.Console.WriteLine("Число " + a + " больше числа " + b );