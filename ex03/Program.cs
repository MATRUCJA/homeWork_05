//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int FindMinSumOfRows(int[,] matrix)
{
    int[] means = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        means[i] = rowSum;
    }
    int minMean = means[0];
    int minRow = 0;
    for (int m = 1; m < matrix.GetLength(0); m++)
    {
        if (means[m] < minMean)
        {
            minMean = means[m];
            minRow = m;
        }
    }
    return minRow;
}
int[,] res = CreateMatrix(3, 4, 0, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(res);
int minRow = FindMinSumOfRows(res);
Console.WriteLine($"Ряд с минимальной суммой элементов: {minRow}");