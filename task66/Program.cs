﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfElem (int m, int n)
{
    int summOfElem = m;
    if (m-1 == n || n-1 == m)
        summOfElem = m+n;
    else if (m < n)
        summOfElem = m + SumOfElem (m+1, n);
    else if (m > n)
        summOfElem = m + SumOfElem (m-1, n);
    else
        summOfElem = m;
    return summOfElem;
}

Console.WriteLine("Input first number:");
int userM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int userN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your result is {SumOfElem(userM, userN)}");