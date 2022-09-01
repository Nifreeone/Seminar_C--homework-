// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество строк и столбца 1 и столбца 2 через Enter и задайте трехмерный массив (Максимальное количество элементов 90  ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int l = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = FillMatrix(m, n, l);
PrintMatrix(matrix);

int[,,] FillMatrix(int rowsCount, int columns1Count, int columns2Count, int leftRange = 10,
int rightRange = 100)

{
    int[,,] matrix = new int[rowsCount, columns1Count, columns2Count];
    Random rand = new Random();
    int tmpnumber;
    int[] tmparray = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    
    for (int l = 0; l < tmparray.GetLength(0); l++)
{
    tmparray[l] = rand.Next(leftRange, rightRange);
    tmpnumber = tmparray[l];
    if (l >= 1)
        {
            for (int t = 0; t < l; t++)
            {
                while (tmparray[l] == tmparray[t])
                {
                    tmparray[l] = rand.Next(leftRange, rightRange);
                    t = 0;
                    tmpnumber = tmparray[l];
                }
                tmpnumber = tmparray[l];
            }
        }
}
    int cnt = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int c = 0; c < matrix.GetLength(2); c++)
            {
                matrix[i, j, c] = tmparray[cnt];
                cnt++;
            }

        }
    }

return matrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int c = 0; c < matrix.GetLength(2); c++)
            {
                Console.Write(matrix[i, j, c] + $"({i},{j},{c}) ");
            }
        }
        Console.WriteLine();
    }
}
