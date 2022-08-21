// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// от 0 до 1 это по сути тоже вещественные числа, поэтому оставил как есть, округлить числа только в массиве 
// не получилось не с :f2, не с tofixed(2), буду благодарен, если подскажите как
double[] array = new double[8];
Random rand = new Random();
double max = 0;
double min = 1;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.NextDouble();

}
for (int j = 0; j < array.Length; j++)
{
    if (max < array[j])
        max = array[j];

    else if (min > array[j])
        min = array[j];
}

double r = max - min;
Console.WriteLine(string.Join(", ", array));
Console.Write($" Минимум={min}  Максимум={max}, Разница между ними {r}");