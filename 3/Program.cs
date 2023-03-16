// * Задача 3:*Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два неотрицательных
// числа m и n.

// m = 2, n = 3->A(m, n) = 29

using System;
using static System.Console;

Write("Введите число M: ");
int m = int.Parse(ReadLine());

Write("Введите число N: ");
int n = int.Parse(ReadLine());

AkkermanFunction(m,n);

void AkkermanFunction(int m, int n)
{
    Console.Write(Ak(m, n)); 
}

int Ak(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ak(m - 1, 1);
    }
    else
    {
        return (Ak(m - 1, Ak(m, n - 1)));
    }
}
