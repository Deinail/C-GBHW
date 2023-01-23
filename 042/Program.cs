// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
System.Console.WriteLine();

Console.WriteLine("");
System.Console.WriteLine("Введите количество чисел");
int ArrLength = Convert.ToInt32(Console.ReadLine());
int [] Array = new int [ArrLength];
int Counter = 0;

for (int i = 0; i < Array.Length; i++)
{
    Console.WriteLine("Введите " + (i+1) + " число");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] < 0)
        Counter++;
}

System.Console.WriteLine($"[{string.Join(", ",  Array)}]"); 
System.Console.WriteLine("Количество чисел больше 0: " + Counter);