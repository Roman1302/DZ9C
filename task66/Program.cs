/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

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

int SumNumberInterval(int min, int max)
{
    int sum = 0;
    for (int i = min; i <= max; i++)
    {
        sum = i + sum;
    }
    return sum;
}

int m = Input("Введите начальное число (M): ");
int n = Input("Введите конечное число (N): ");
Console.WriteLine();
Console.WriteLine($"M = {m}; N = {n} -> {SumNumberInterval(m,n)}");