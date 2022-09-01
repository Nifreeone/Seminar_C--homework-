// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк и столбцов через Enter и задайте 1 матрицу ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк и столбцов через Enter и задайте 2 матрицу ");
int k = Convert.ToInt32(Console.ReadLine());
int l = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = FillMatrix(m, n);
int[,] matrix2 = FillMatrix(k, l);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 1, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");

        }
        Console.WriteLine();
    }
}

Console.WriteLine();
int[,] multi = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int c = 0; c < matrix2.GetLength(0); c++)
            {
                multi[i, j] =  multi[i, j] + matrix1[i, c] * matrix2[c, j];
           }
        }
    }
    PrintMatrix(multi);

}
else
{
    Console.WriteLine($"Число столбцов первой матрицы должен быть равен числу строк второй матрицы");
}
