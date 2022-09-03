/* Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

Console.WriteLine("Введите начальное число (M): ");
if (!int.TryParse(Console.ReadLine()!, out int m))
    Console.WriteLine("Что-то пошло не так");

Console.WriteLine("Введите конечное число (N): ");
if (!int.TryParse(Console.ReadLine()!, out int n))
    Console.WriteLine("Что-то пошло не так");

for (int i = m; i <= n; i++)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();