// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Write("Введите m и n через Enter и задайте массив ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
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

Console.Write("Введите номер строки и столбца нужного элемента в матрице через Enter ");
int imatrix = Convert.ToInt32(Console.ReadLine());
int jmatrix = Convert.ToInt32(Console.ReadLine());

if (imatrix <= m && jmatrix <= n) 
{
    Console.Write("Значением под данной позицией является = ");
    Console.Write(matrix.GetValue(imatrix -1, jmatrix -1));  // или Console.Write(matrix[imatrix-1, jmatrix-1] + " ");
}
else 
{
    Console.Write("Данной позиции не существует");
}

