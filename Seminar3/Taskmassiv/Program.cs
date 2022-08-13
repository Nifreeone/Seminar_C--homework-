// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.WriteLine("Введите количество элементов в массиве = ");

int nubmber = Convert.ToInt32(Console.ReadLine());
int[] array= new int[nubmber];
int n = array.Length;

for (int ind = 0; ind < n; ind++) 
{
Console.WriteLine("Введите массив отдельно по цифрам = ");
array[ind] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < n / 2; i++)
{
   int tmp = array[i];
   array[i] = array[n - i - 1];
   array[n - i - 1] = tmp;
}
for (int index = 0; index < n; index++)
{
Console.Write(array[index]);
}
