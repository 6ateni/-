// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int FindAckerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return FindAckerman(n - 1, 1);
    }
    else
    {
        return FindAckerman(n - 1, FindAckerman(n, m - 1));
    }
}
Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
FindAckerman(M, N);
Console.Write($"Функция Аккермана = {FindAckerman(M, N)}");