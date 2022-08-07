// // Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое положительное число = ");

int N = Convert.ToInt32(Console.ReadLine());

int counter = 0;

if (N > 0)

    while (counter <= N)
{
    Console.Write(counter + " ");
    counter+=2;
}
else
{
     Console.WriteLine("Введите положительное число");

}