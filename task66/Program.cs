// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumFromMToN(int m, int n, int sum)
{
    if (n == m)
    {
       return n;
    }
    sum = n + SumFromMToN(m, n - 1, sum);
    return sum;
}

System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

System.Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {SumFromMToN(m, n, sum)}");
