/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите начальное число (M): ");
if (!int.TryParse(Console.ReadLine()!, out int m))
    Console.WriteLine("Что-то пошло не так");

Console.WriteLine("Введите конечное число (N): ");
if (!int.TryParse(Console.ReadLine()!, out int n))
    Console.WriteLine("Что-то пошло не так");
int sum = 0;
for (int i = m; i <= n; i++)
{
    sum = i + sum;
}
Console.WriteLine();
Console.WriteLine($"M = {m}; N = {n} -> {sum}");