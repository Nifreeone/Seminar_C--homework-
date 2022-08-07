// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите первое число = ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число = ");

int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Второе чило является квдратом первого");
}
else
{
    Console.WriteLine("Второе чило НЕ является квдратом первого");

}

