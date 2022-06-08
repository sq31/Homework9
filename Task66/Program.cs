/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int Sum(int from, int to)
{
    return from == to ? to : from + Sum(from + 1, to);
}

Console.Write("Введите число M: ");
int fromM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int toN = Convert.ToInt32(Console.ReadLine());

Sum(fromM, toN);

int result = Sum(fromM, toN);
Console.WriteLine(result);
