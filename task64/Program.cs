// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void FillNaturalTo1(int n)
{
    if (n > 1)
    {
        Console.Write($"{n}, ");
        FillNaturalTo1(n - 1);
    }
    if (n == 1)
        Console.Write($"{n}.");

}

Console.WriteLine("Input number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
while (userNumber < 1)
{
    Console.WriteLine("Error! Input only NATURAL (>0) numbers:");
    userNumber = Convert.ToInt32(Console.ReadLine());
}
FillNaturalTo1(userNumber);