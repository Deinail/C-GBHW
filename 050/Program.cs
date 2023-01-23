// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void InputMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (100 - 1) + 1, 2); // [1, 100]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();

    }
}

Console.Clear();
double[,] matrix = new double [new Random().Next(1,10), new Random().Next(1,10)];
InputMatrix(matrix);

System.Console.Write("Введите позицию элемента через пробел: ");
int[] Position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

if (matrix.GetLength(0) > Position[0] && matrix.GetLength(1) > Position[1])
{
    Console.Write($"{matrix[Position[0], Position[1]]}");
}

else
{
    System.Console.WriteLine("такого элемента нет");
}

