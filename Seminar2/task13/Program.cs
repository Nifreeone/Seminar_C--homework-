// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число = ");

int a = Convert.ToInt32(Console.ReadLine());
 
if (-100 < a & a < 100)
{
    Console.WriteLine("Третьего числа нет");
}
else 
{
int i = 0;
while (a > 1000)

{
 i = i + 1;
 a = a / 10;
}

 int number3 = a % 10;
 

    Console.WriteLine("Третье число " + number3);
}