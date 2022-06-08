/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

int AkkermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return AkkermanFunc(m - 1, 1);
    else
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

AkkermanFunc(numM, numN);

int result = AkkermanFunc(numM, numN);
Console.WriteLine(result);
