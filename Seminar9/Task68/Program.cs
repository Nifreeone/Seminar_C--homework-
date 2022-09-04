// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// n = 2, m = 3 -> A(m,n) = 9

Console.WriteLine("Введите число n");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m");
int numberM = Convert.ToInt32(Console.ReadLine());


if (numberM >= 0 && numberN >= 0)
{
    int sum = SumMToN(numberN, numberM);
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Число M и N не могут быть отрицательными");
}

int SumMToN(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return SumMToN(m - 1, 1);
    }
    else
    {
        return SumMToN(m - 1, SumMToN(m, n - 1));
    }
}