//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

System.Console.WriteLine();

System.Console.Write("Введите целое число:   ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  /// для проверки текста на палиндром

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (IsPalindrome()) System.Console.WriteLine($"1. Введный текст/число - {number} - является палиндромом");
else System.Console.WriteLine($"1. Число {number} не является палиндромом");
System.Console.WriteLine();

