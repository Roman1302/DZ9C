/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

int Ackerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Ackerman(n - 1, 1);
    else
        return Ackerman(n - 1, Ackerman(n, m - 1));
}

int Input(string messege)
{
InputVackermanlue:
    Console.Write(messege);
    if (!int.TryParse(Console.ReadLine()!, out int value))
    {
        Console.WriteLine("Что-то пошло не так");
        goto InputVackermanlue;
    }
    return value;
}

int m = Input("Введите начальное число (M): ");
int n = Input("Введите конечное число (N): ");

Console.WriteLine();
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Ackerman(n, m)}");