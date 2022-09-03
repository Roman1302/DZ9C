/* Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

int Input(string messege)
{
InputValue:
    Console.Write(messege);
    if (!int.TryParse(Console.ReadLine()!, out int value))
    {
        Console.WriteLine("Что-то пошло не так");
        goto InputValue;
    }
    return value;
}

int m = Input("Введите начальное число (M): ");
int n = Input("Введите конечное число (N): ");

for (int i = m; i <= n; i++)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();