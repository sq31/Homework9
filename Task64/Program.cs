/*
Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4"
*/ 

void PrintNumbersToN(int numbFrom, int numbTo)
{
    if (numbTo > numbFrom)
    {
        Console.Write($"{numbTo--}, ");
        PrintNumbersToN(numbFrom, numbTo);
    }
    else
    {
        Console.Write($"{numbTo}");
    }
}

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumbersToN(1, number);

