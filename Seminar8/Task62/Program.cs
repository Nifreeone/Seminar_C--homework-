// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

Console.Write("Введите количество строк и столбцов через Enter и задайте массив ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int k = 1;

int[,] matrix = new int[m, n];

for (int y = 0; y < n; y++)
{
    matrix[0, y] = k;
    k++;
}
for (int x = 1; x < m; x++)
{
    matrix[x, n - 1] = k;
    k++;
}
for (int y = n - 2; y >= 0; y--)
{
    matrix[m - 1, y] = k;
    k++;
}
for (int x = m - 2; x > 0; x--)
{
    matrix[x, 0] = k;
    k++;
}

int c = 1;
int d = 1;

while (k < m * n)
{

    while (matrix[c, d + 1] == 0)
    {
        matrix[c, d] = k;
        k++;
        d++;
    }

    while (matrix[c + 1, d] == 0)
    {
        matrix[c, d] = k;
        k++;
        c++;
    }
    while (matrix[c, d - 1] == 0)
    {
        matrix[c, d] = k;
        k++;
        d--;
    }
    while (matrix[c - 1, d] == 0)
    {
        matrix[c, d] = k;
        k++;
        c--;
    }
}
for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (matrix[x, y] == 0)
        {
            matrix[x, y] = k;
        }
    }
}

void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 10 <= 0)
                Console.Write($" {matrix[i, j]} ");

            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintMatrix(matrix);
