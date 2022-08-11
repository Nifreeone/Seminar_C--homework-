// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число = ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число = ");

int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b || b == a * a)
{
    Console.WriteLine("Одно чило является квдратом второго");
}
else
{
    Console.WriteLine("Числа чило НЕ являются квдратом друг друга");

}

