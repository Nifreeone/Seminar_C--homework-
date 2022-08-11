// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковое число дня");

int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("Рабочий день");
        break;
    case 2:
        Console.WriteLine("Рабочий день");
        break;
    case 3:
        Console.WriteLine("Рабочий день");
        break;
    case 4:
        Console.WriteLine("Рабочий день");
        break;
    case 5:
        Console.WriteLine("Рабочий день");
        break;
    case 6:
        Console.WriteLine("Выходной");
        break;
    case 7:
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("Нет такого дня недели");
        break;


}