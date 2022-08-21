// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран. Вводим массив через консоль



// Сделал универсальный ввод в 2 вариантах, а не только для 8 элементов
//  1 Вариант
Console.WriteLine("Введите количество элементов в массиве = ");

int number = Convert.ToInt32(Console.ReadLine());
int[] array= new int[number];
int n = array.Length;

for (int ind = 0; ind < n; ind++) 
{
Console.WriteLine("Введите массив отдельно по цифрам = ");
array[ind] = Convert.ToInt32(Console.ReadLine());
}

Console.Write(string.Join(" " , array));

// 2 Вариант

// Console.WriteLine("Введите элементы массива через пробел = ");

// int [] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

// for (int i = 0; i < array.Length; i++) 
// {
// Console.Write(array[i] + " ");
// }
