// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs (number);
int i;
int sum = 0;
int numbersave = number;
for (i = 0; 0 < number; i++)
{
    numbersave = number % 10;
    number = number / 10;
    sum = numbersave + sum;
}

Console.WriteLine(sum);
